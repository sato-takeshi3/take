using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHousekeepingBook
{
    /// <summary>
    /// ItemFormのクラス
    /// </summary>
    public partial class ItemForm : Form
    {
        /// <summary>
        /// データ処理
        /// </summary>
        /// <param name="dsCategory"></param>
        public ItemForm(CategoryDataSet dsCategory)
        {
            InitializeComponent();
            categoryDataSet.Merge(dsCategory);
        }

        /// <summary>
        /// データを入力する
        /// </summary>
        /// <param name="dsCategory"></param>
        /// <param name="nowDate"></param>
        /// <param name="category"></param>
        /// <param name="item"></param>
        /// <param name="money"></param>
        /// <param name="remarks"></param>
        public ItemForm(CategoryDataSet dsCategory,
                        DateTime nowDate,
                        string category,
                        string item,
                        int money,
                        string remarks)
        {
            InitializeComponent();  //初期化処理
            categoryDataSet.Merge(dsCategory);
            monCalendar.SetDate(nowDate);
            cmbCategory.Text = category;
            txtItem.Text = item;
            mtxtMoney.Text = money.ToString();
            txtRemarks.Text = remarks;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }
    }
}
