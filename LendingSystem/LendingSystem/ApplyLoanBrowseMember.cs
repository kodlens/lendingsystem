using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LendingSystem
{
    
    public partial class ApplyLoanBrowseMember : Form
    {
        ApplyLoanMainForm _frm;

        public ApplyLoanBrowseMember(ApplyLoanMainForm _frm)
        {
            InitializeComponent();

            this._frm = _frm;
        }
    }
}
