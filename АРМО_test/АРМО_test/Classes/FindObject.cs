using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;

namespace ARMO_test
{
    public partial class ARMO_test_Form : Form
    {
        delegate void SimpleDelegate();
        delegate void AddNodeDelegate(TreeNode p, TreeNode t);
        delegate void ExpNodeDelegate(TreeNode t);

        private BackgroundWorker bw = new BackgroundWorker();
        private UInt64 objCount = 0;
       
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            TreeNode rootN = null;
            if (ResultView.InvokeRequired)
                ResultView.Invoke((SimpleDelegate)(() => { rootN = ResultView.TopNode; }));
            else
                rootN = ResultView.TopNode;

            string filter = "";
            if (m_search_filter.InvokeRequired)
                m_search_filter.Invoke((SimpleDelegate)(() => { filter = m_search_filter.SearchFilterText.Text; }));
            else
                filter = m_search_filter.SearchFilterText.Text;
            
            Search(ref rootN, filter);           

            if (this.InvokeRequired)
                this.Invoke((SimpleDelegate)(() => { Stop(); }));
            else
                Stop();
            e.Cancel = true;
        }

        #region Делегаты
        private AddNodeDelegate add_node = delegate(TreeNode p, TreeNode t)
        {
           p.Nodes.Add(t);
        };

        private ExpNodeDelegate exp_node = delegate(TreeNode t)
        {
            if (t.Parent != null)
                t.Parent.Expand();
        };
        #endregion

        //Поиск папок
        private void Search(ref TreeNode curN, string s_f)
        {
            SearchPauseEvent.WaitOne();

            if (bw.CancellationPending || curN == null)
                return;

            string cur_s = curN.Tag.ToString();
            if (mainStatus.InvokeRequired)
                mainStatus.Invoke((SimpleDelegate)(() => { SearchInLabel.Text = cur_s; }));
            else
                CountLabel.Text = SearchInLabel.Text = cur_s;

            if (curN.Level == 1)
            {
                if (ResultView.InvokeRequired)
                    ResultView.Invoke(exp_node, curN);
                else
                    exp_node(curN);
            }

            List<string> dirs = new List<string>();                
            try
            {
                dirs = Directory.GetDirectories(curN.Tag.ToString()).ToList();

                List<string> sh_nms = dirs.Select(x => x.Substring(x.LastIndexOf(Path.DirectorySeparatorChar) + 1)).ToList();
                sh_nms = sh_nms.Where(x => Regex.IsMatch(x, s_f)).ToList();
                string p = curN.Tag.ToString();
                dirs = sh_nms.Select(x => Path.Combine(p, x)).ToList();
            }
            catch (UnauthorizedAccessException) { }
            
            if (dirs.Count == 0)
            {
                SearchFiles(curN, s_f);
                if (mainStatus.InvokeRequired)
                    mainStatus.Invoke((SimpleDelegate)(() => { CountLabel.Text = (objCount).ToString("Найдено объектов: 0"); }));
                else
                    CountLabel.Text = objCount.ToString("Найдено объектов: 0");

                curN = curN.Parent;

                return;
            }

            dirs.Sort();
            foreach (string d in dirs)
            {
                if (mainStatus.InvokeRequired)
                    mainStatus.Invoke((SimpleDelegate)(() => { CountLabel.Text = (++objCount).ToString("Найдено объектов: 0"); }));
                else
                    CountLabel.Text = (++objCount).ToString("Найдено объектов: 0");

                TreeNode t = CreateNode(d, true);
                if (ResultView.InvokeRequired)
                    ResultView.Invoke(add_node, curN, t);
                else
                    add_node(curN, t);

                curN = t;

                Search(ref curN, s_f);
            }
            SearchFiles(curN, s_f);

            curN = curN.Parent;
        }

        //Поиск файлов
        private void SearchFiles(TreeNode curN, string s_f)
        {
            List<string> files = new List<string>();
            try
            {
                files = Directory.GetFiles(curN.Tag.ToString()).ToList();

                List<string> sh_nms = files.Select(x => x.Substring(x.LastIndexOf(Path.DirectorySeparatorChar) + 1)).ToList();
                sh_nms = sh_nms.Where(x => Regex.IsMatch(x, s_f)).ToList();
                string p = curN.Tag.ToString();
                files = sh_nms.Select(x => Path.Combine(p, x)).ToList();
            }
            catch (UnauthorizedAccessException) { }
            
            files.Sort();
            foreach (string f in files)
            {
                if (mainStatus.InvokeRequired)
                    mainStatus.Invoke((SimpleDelegate)(() => { CountLabel.Text = (++objCount).ToString("Найдено объектов: 0"); }));
                else
                    CountLabel.Text = (++objCount).ToString("Найдено объектов: 0");

                TreeNode t = CreateNode(f, false);
                if (ResultView.InvokeRequired)
                    ResultView.Invoke(add_node, curN, t);
                else
                    add_node(curN, t);
            }
        }

        TreeNode CreateNode(string path, bool isDir)
        {
            TreeNode retN = null;

            string n_text = path.TrimEnd(Path.DirectorySeparatorChar).Split(Path.DirectorySeparatorChar).Reverse().ToArray()[0];
            if (string.IsNullOrWhiteSpace(n_text))
                n_text = Path.GetPathRoot(path);

            retN = new TreeNode()
            {
                Text = n_text,
                Tag = path,
                ImageIndex = (isDir) ? 0 : 2,
                SelectedImageIndex = (isDir) ? 0 : 2
            };

            return retN;
        }

    }
}
