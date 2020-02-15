using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtLib
{
    public partial class BaseForm : MetroFramework.Forms.MetroForm
    {
        private static BaseForm _instance;
        public static BaseForm Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new BaseForm();
                }
                return _instance;
            }
        }
        public MetroFramework.Controls.MetroPanel Container
        {
            get { return metroPanel1; }
            set { metroPanel1 = value; }
        }
        public MetroFramework.Controls.MetroLink BackBtn
        {
            get { return metroLink1; }
            set { metroLink1 = value; }
        }
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            BackBtn.Enabled = false;
            _instance = this;
            Pages.MainMenu mainMenu = new Pages.MainMenu();
            mainMenu.Dock = DockStyle.Fill;
            Container.Controls.Add(mainMenu);
        }
        public void SetTitle(string title)
        {
            Text = "      " + title;
        }
    }
}
