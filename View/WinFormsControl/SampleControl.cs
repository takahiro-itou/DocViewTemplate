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
        public String InputText
        {
            get { return txtInput.Text; }
            set { txtInput.Text = value; }
        }

        //----------------------------------------------------------------
        //    OutputText プロパティ
        //
        public String OutputText
        {
            get { return txtOutput.Text; }
            set { txtOutput.Text = value; }
        }
    }
}
