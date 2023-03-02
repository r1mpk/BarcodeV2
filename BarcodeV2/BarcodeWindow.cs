using System.Drawing.Printing;
using static System.Windows.Forms.LinkLabel;

namespace BarcodeV2
{
    public partial class BarcodeWindow : Form
    {
        public readonly string filePath = @"Models.txt";
        public List<Model> models = new();
        public string BarVal = string.Empty;
        public BarcodeWindow()
        {
            InitializeComponent();
            //Initial Model List read
            RefreshMyList();
           
        }

        private void BtAddNewModel_Click(object sender, EventArgs e)
        {
            if (AddModelsID.Text != "" && AddModelsPN.Text != "")
            {
                Model _model = new(AddModelsID.Text, AddModelsPN.Text);
                SaveDataToDataSource(_model);
                AddModelsID.Clear();
                AddModelsPN.Clear();
                RefreshMyList();
            }
            else
            {
                MessageBox.Show("You can not add empty ID/PN.", "Error", MessageBoxButtons.OK);
            }

        }
        private void BtRefreshButton_Click(object sender, EventArgs e)
        {
            RefreshMyList();
        }
        private void SaveDataToDataSource(Model _model)
        {
            using (StreamWriter _writer = File.AppendText(filePath))
            {
                _writer.WriteLine(_model.MyModel + "|" + _model.MyPartNum);
            }
        }
        private void ReadDataFromDataSource(List<Model> _models)
        {
            _models.Clear();
            using (StreamReader _reader = new(filePath))
            {
                string _line;
                while ((_line = _reader.ReadLine()) != null)
                {
                    string[] _parts = _line.Split("|");
                    if (_parts.Length == 2)
                    {
                        string _id = _parts[0];
                        string _pn = _parts[1];
                        Model _model = new(_id, _pn);
                        _models.Add(_model);
                    }
                }
            }
        }
        private void RefreshMyList()
        {
            ModelsComboBox.Text = "";
            ReadDataFromDataSource(models);
            ModelsComboBox.Items.Clear();
            foreach(Model _model in models)
            {
                ModelsComboBox.Items.Add(_model);
            }
            ModelsComboBox.DisplayMember = "MyModel";
            ModelsComboBox.ValueMember = "MyPartNum";
            
        }
        private void BtDelete_Click(object sender, EventArgs e)
        {
            string _searchedValue = ((BarcodeV2.Model)ModelsComboBox.SelectedItem).MyModel.ToString();
            List<string> _lines = new();          
            try
            {
                using (StreamReader _reader = new(filePath))
                {
                    string _line;
                    while ((_line = _reader.ReadLine()) != null)
                    {
                        _lines.Add(_line);
                    }

                }
                int _index = _lines.FindIndex(_line => _line.Split('|')[0] == _searchedValue);
                if (_index >= 0)
                {
                    _lines.RemoveAt(_index);
                    using (StreamWriter _writer = new(filePath))
                    {
                        foreach (string line in _lines)
                        {
                            _writer.WriteLine(line);
                        }
                    }
                    MessageBox.Show("Line Deleted Successfully!");
                    RefreshMyList();
                } else
                {
                    MessageBox.Show("Line Not Found!");
                }
                
                
                
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
        private string GenerateFullPartNum(string _partNum)
        {
            TodaysDate _today = new();
            _today.GenerateTodaysDate();
            _partNum = _partNum + "PTS" + _today.finval + "0001";
            return _partNum;
            //TO CREATE 0001 - quantity.ToString("D4")
        }
        private void BtPrint_Click(object sender, EventArgs e)
        {
            var printDocument = new System.Drawing.Printing.PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                e.Graphics.DrawImage(BarcodePreview.Image, new Point(0, 0)); // draw the image at the top-left corner of the page
            };
            printDocument.Print();
        }
        private void BtPreview_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            var barcodeImage = barcode.Draw(GenerateFullPartNum(BarVal), 50);

            var resultImage = new Bitmap(barcodeImage.Width, barcodeImage.Height + 20); // 20 is bottom padding, adjust to your text

            using (var graphics = Graphics.FromImage(resultImage))
            using (var font = new Font("Consolas", 12))
            using (var brush = new SolidBrush(Color.Black))
            using (var format = new StringFormat()
            {
                Alignment = StringAlignment.Center, // Also, horizontally centered text, as in your example of the expected output
                LineAlignment = StringAlignment.Far
            })
            {
                graphics.Clear(Color.White);
                graphics.DrawImage(barcodeImage, 0, 0);
                graphics.DrawString(GenerateFullPartNum(BarVal), font, brush, resultImage.Width / 2, resultImage.Height, format);
            }

            BarcodePreview.Image = resultImage;
        }

        private void ModelsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string selectedValue = ((Model)cmb.SelectedItem).MyPartNum.ToString();
            BarVal = selectedValue;
        }
    }
    //Model Class
    public class Model
    {
        private readonly string myModel;
        private readonly string myPartNum;
        public Model()
        {
            this.myModel = string.Empty;
            this.myPartNum = string.Empty;
        }
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
    //Date Class for 3 YMD characters in barcode
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
}
