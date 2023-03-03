using System.Drawing.Drawing2D;
using System.Drawing.Printing;

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
            if (AddModelsID.Text != string.Empty && AddModelsPN.Text != string.Empty)
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
        //Delete Model from the list
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
                }
                else
                {
                    MessageBox.Show("Line Not Found!");
                }



            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        //Print
        private void BtPrint_Click(object sender, EventArgs e)
        {
            int _quant = 1;
            //Print selected quantity at the top left corner of a page
            try
            {
                _quant = Int32.Parse(QuantityBox.Text);
            } catch (FormatException ex)
            {
                _quant = 1;
            }
                for (int i = 1; i <= _quant; i++)
            {
                var printDocument = new System.Drawing.Printing.PrintDocument();
                printDocument.PrintPage += (sender, e) =>
                {
                    string finalValBarcode = GenerateFullPartNum(BarVal).Substring(0, 17);
                    finalValBarcode += i.ToString("D4");
                    e.Graphics.DrawImage(BarcodeGen(finalValBarcode), new Point(0, 0)); // draw the image at the top-left corner of the page
                };
                printDocument.Print();
            }

        }
        //Display barcode preview in the program
        private void BtPreview_Click(object sender, EventArgs e)
        {
            BarcodePreview.Image = BarcodeGen(GenerateFullPartNum(BarVal));
            //Stretch to fill the whole preview box
            BarcodePreview.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        //Change Select index so the Selected Value also changes
        private void ModelsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string selectedValue = ((Model)cmb.SelectedItem).MyPartNum.ToString();
            BarVal = selectedValue;
        }
        //Save the data to the Models.txt
        private void SaveDataToDataSource(Model _model)
        {
            using (StreamWriter _writer = File.AppendText(filePath))
            {
                _writer.WriteLine(_model.MyModel + "|" + _model.MyPartNum);
            }
        }
        //Read the data to the Models.txt
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
        //ComboBox list refresher
        private void RefreshMyList()
        {
            ModelsComboBox.Text = "";
            ReadDataFromDataSource(models);
            ModelsComboBox.Items.Clear();
            foreach (Model _model in models)
            {
                ModelsComboBox.Items.Add(_model);
            }
            ModelsComboBox.DisplayMember = "MyModel";
            ModelsComboBox.ValueMember = "MyPartNum";

        }
        //Selected model + PTS + Date + Serial num
        private string GenerateFullPartNum(string _partNum)
        {
            //Generate full part number for printing
            TodaysDate _today = new();
            _today.GenerateTodaysDate();
            _partNum = _partNum + "PTS" + _today.finval + "0001";
            return _partNum;
        }
        //Generate High Quality Barcode with Text Underneath
        private Bitmap BarcodeGen(string _barcodeText)
        {
            Zen.Barcode.Code93BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code93WithChecksum;
            var barcodeImage = barcode.Draw(_barcodeText, 50);
            var resultImage = new Bitmap(barcodeImage.Width, barcodeImage.Height + 14); // Bottom Padding
            using (var graphics = Graphics.FromImage(resultImage))
            using (var font = new Font("Consolas", 8))
            using (var brush = new SolidBrush(Color.Black))
            using (var format = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Far
            })
            {
                //Best Quality possible settings
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.Clear(Color.White);
                graphics.DrawImage(barcodeImage, 0, 0);
                graphics.DrawString(_barcodeText, font, brush, resultImage.Width / 2, resultImage.Height, format);
            }
            
            return resultImage;
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

        public string GenerateTodaysDate()
        {
            DateTime thisDay = DateTime.Today;
            int year = thisDay.Year - 2020;
            int month = thisDay.Month;
            int day = thisDay.Day;
            string finDateX = string.Empty;
            finDateX += Convert.ToChar(year + 48);
            if (month <= 9)
            {
                finDateX += Convert.ToChar(month + 48);
            }
            else
            {
                finDateX += Convert.ToChar(month + 64);
            }
            if (day <= 9)
            {
                finDateX += Convert.ToChar(day + 48);
            }
            else
            {
                if (day > 9 && day < 18)
                {
                    finDateX += Convert.ToChar(day + 64);
                }
                else if (day > 17 && day < 24)
                {
                    finDateX += Convert.ToChar(day + 65);
                }
                else if (day > 24)
                {
                    finDateX += Convert.ToChar(day + 66);

                }
            }
            return finval = new string(finDateX);
        }
    }
}
