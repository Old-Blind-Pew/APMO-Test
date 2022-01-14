using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

using ARMO_test.Config;
using System.Threading;


namespace ARMO_test
{
    public partial class ARMO_test_Form : Form
    {
        private const string DoSearch = "Начать поиск";
        private const string DoStop = "Остановить поиск";
        private const string DoPause = "Преостановить поиск";
        private const string DoResume = "Возобновить поиск";

        private enum CheckConfigEvents { OnLoad, OnSearch, OnClose}
        private enum CurStates { Stop, Search, Pause}
        private ConfigClass conf = new ConfigClass();

        ManualResetEvent SearchPauseEvent = new ManualResetEvent(true);

        private CurStates cur_state = CurStates.Stop;

        private System.Windows.Forms.Timer m_tm = new System.Windows.Forms.Timer();
        DateTime start_tm;

        public ARMO_test_Form()
        {
            InitializeComponent();

            TimeLabel.Alignment = ToolStripItemAlignment.Right;

            my_Initialize();
        }

        private void my_Initialize()
        {
            ConfigClass.ConfigStr cf = conf.GetConfig();
            m_directorySource.Init(cf.SearchStartPath);
            m_search_filter.Init(cf.SearchTemplate);
            
            bw.WorkerSupportsCancellation = true;
            bw.WorkerReportsProgress = true;

            bw.DoWork += new DoWorkEventHandler(bw_DoWork);

            m_tm.Interval = 1000;
            m_tm.Tick += new EventHandler(m_tm_Tick); 

            StartStopBut.Text = DoSearch;
            PauseResumeBut.Text = DoPause;

            ResultView.ImageList = NodeImageList;
        }

        void m_tm_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = (DateTime.Now - start_tm).ToString(@"hh\:mm\:ss");
            Application.DoEvents();
        }

        private bool CheckConfig(bool withMessage)
        {
            bool ret = false;
            ret = Directory.Exists(m_directorySource.DirectorySourceText.Text.Trim());

            if(ret)
                try { new Regex(m_search_filter.SearchFilterText.Text); }
                catch (ArgumentException) { ret = false; }

            if (!ret && withMessage)
                MessageBox.Show("Недопустимое значение пути или шаблона поиска", 
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return ret;
        }

        private void ARMO_test_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();

            if (CheckConfig(false))
                conf.SetConfig
                    (
                        new ConfigClass.ConfigStr()
                        {
                            SearchStartPath = m_directorySource.DirectorySourceText.Text.Trim(),
                            SearchTemplate = m_search_filter.SearchFilterText.Text.Trim()
                        }
                    );
        }

        private void StartStopBut_Click(object sender, EventArgs e)
        {
            if(cur_state == CurStates.Stop && !CheckConfig(true))
                return;

            if(cur_state == CurStates.Stop)
            {
                ClearCotrols();
                if (!InitCotrols())
                    return;

                cur_state = CurStates.Search;
                StartStopBut.Text = DoStop;
                PauseResumeBut.Text = DoPause;

                PauseResumeBut.Visible = true;

                m_directorySource.Enabled = m_search_filter.Enabled = false;

                objCount = 0;
                bw.RunWorkerAsync();

                start_tm = DateTime.Now;
                m_tm.Start();
            }
            else
                Stop();
        }

        private void Stop()
        {
            bw.CancelAsync();

            m_tm.Stop();

            ClearCotrols(true);

            cur_state = CurStates.Stop;
            StartStopBut.Text = DoSearch;

            PauseResumeBut.Visible = false;

            m_directorySource.Enabled = m_search_filter.Enabled = true;

            SearchPauseEvent.Set();
        }

        private void PauseResumeBut_Click(object sender, EventArgs e)
        {
            if (cur_state == CurStates.Search)
            {
                cur_state = CurStates.Pause;
                PauseResumeBut.Text = DoResume;

                SearchPauseEvent.Reset();
            }
            else
            {
                cur_state = CurStates.Search;
                PauseResumeBut.Text = DoPause;

                SearchPauseEvent.Set();
            }
        }

        private bool InitCotrols()
        {
            try
            {
                ResultView.Nodes.Add(CreateNode(m_directorySource.DirectorySourceText.Text.Trim(), true));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message,"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            TimeLabel.Text = "00:00:00";
            CountLabel.Text = "";

            return true;
        }

        private void ClearCotrols(bool isRuntimeOnly = false)
        {
            SearchInLabel.Text = TimeLabel.Text = "";
            if (!isRuntimeOnly)
            {
                CountLabel.Text = "";
                ResultView.Nodes.Clear();
            }
        }

        private void ResultView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 0;
            e.Node.SelectedImageIndex = 0;
        }

        private void ResultView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
            e.Node.SelectedImageIndex = 1;
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
