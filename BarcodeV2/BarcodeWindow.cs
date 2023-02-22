namespace BarcodeV2
{
    public partial class BarcodeWindow : Form
    {
        public BarcodeWindow()
        {
            InitializeComponent();
        }

        private void ModelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class Model
    {
        private readonly string myModel;
        private readonly string myPartNum;
        public Model(string strModel, string strPartNum)
        {
            this.myModel = strModel;
            this.myPartNum = strPartNum;
        }
        public string MyModel
        {
            get { return myModel; }
        }
        public string MyPartNum
        {
            get { return myPartNum; }
        }
    }
    public class TodaysDate
    {
        public string finval = string.Empty;

        public void GenerateTodaysDate()
        {
            DateTime thisDay = DateTime.Today;
            int year = thisDay.Year - 2020;
            int month = thisDay.Month;
            int day = thisDay.Day;
            char[] finDateX = { 'E', 'R', 'R' };
            finDateX[0] = Convert.ToChar(year + 48);
            if (month <= 9)
            {
                finDateX[1] = Convert.ToChar(month + 48);
            }
            else
            {
                finDateX[1] = Convert.ToChar(month + 64);
            }
            if (day <= 9)
            {
                finDateX[1] = Convert.ToChar(day + 48);
            }
            else
            {
                if (day > 9 && day < 18)
                {
                    finDateX[2] = Convert.ToChar(day + 64);
                }
                else if (day > 17 && day < 24)
                {
                    finDateX[2] = Convert.ToChar(day + 65);
                }
                else if (day > 24)
                {
                    finDateX[2] = Convert.ToChar(day + 66);

                }
            }
            finval = new string(finDateX);
        }
    }
    /*public class DataFile{
        string folderPath = @"C:\"
    }
    */
}
