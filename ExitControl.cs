using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA230110_3
{
    public partial class ExitControl : UserControl
    {
        public ExitControl()
        {
            InitializeComponent();
            btnOk.Click += OnBtnOkClick;
            btnIgen.Click += OnBtnIgenClick;
            btnExit.Click += OnBtnExitClick;
        }
        private void OnBtnExitClick(object? sender, EventArgs e) => Application.Exit();
        private void OnBtnIgenClick(object? sender, EventArgs e) => Application.Exit();
        private void OnBtnOkClick(object? sender, EventArgs e) => Application.Exit();
    }
}
