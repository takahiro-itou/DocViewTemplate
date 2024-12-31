
using System.ComponentModel;

namespace WinFormsControl
{
    public partial class SampleControl : UserControl
    {
        public SampleControl()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------
        //    InputText プロパティ
        //
        [Browsable(true)
          , Description("入力テキストボックスに入力された文字列")
          , Category("表示")
        ]
        public String InputText
        {
            get { return txtInput.Text; }
            set { txtInput.Text = value; }
        }

        //----------------------------------------------------------------
        //    OutputText プロパティ
        //
        [Browsable(true)
          , Description("出力テキストボックスに表示する文字列")
          , Category("表示")
        ]
        public String OutputText
        {
            get { return txtOutput.Text; }
            set { txtOutput.Text = value; }
        }

        //----------------------------------------------------------------
        /**   イベントハンドラ
        **
        **    「クリア」ボタンのクリックイベント
        **/
        private btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
        }
    }
}
