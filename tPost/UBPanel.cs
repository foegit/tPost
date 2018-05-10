using System;
using System.Drawing;
using System.Windows.Forms;

namespace tPost
{
    public class UBPanel : Panel
    {
        public UrlButtonData UbData;
        private Label _title;
        private Label _url;
        private Label _indentLabel;
        private Button _delButton;
        private ToolTip _tip;

        public event EventHandler  DelButtonClick;

        public UBPanel(string title, string url)
        {
            _tip = new ToolTip();
            UbData = new UrlButtonData(title, url);
            //_url = new Label();
            //_url.Text = url;
            //_url.BackColor = Color.Transparent;
            //_url.ForeColor = Color.White;
            //_url.Dock = DockStyle.Right;


            //_url.TextAlign = ContentAlignment.MiddleCenter;
            //_url.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold);

            _indentLabel = new Label();

            _indentLabel.Width = 10;
            _indentLabel.Dock = DockStyle.Right;

            _title = new Label();
            _title.Text = title;
            _title.BackColor = Color.Transparent;
            _title.ForeColor = Color.White;
            _title.Width = Width;
            _title.Height = 24;

            _title.TextAlign = ContentAlignment.MiddleCenter;
            _title.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold);
            _title.MouseHover += (sender, args) =>
            {
                _title.BackColor = Color.LightGreen;
                
                _tip.Show(url,this, Cursor.HotSpot);

            };
            _title.MouseLeave += (sender, args) =>
            {
                _title.BackColor = Color.Transparent;
                _tip.Hide(this);

            };

            _delButton = new Button(); ;
            _delButton.Dock = DockStyle.Right;
            _delButton.Text = "X";
            _delButton.FlatStyle = FlatStyle.Flat;
            _delButton.ForeColor = Color.DarkRed;
            _delButton.BackColor = Color.WhiteSmoke;
            _delButton.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold); ;
            _delButton.Width = 24;
            _delButton.Height = 24;
            _delButton.Click += (sender, args) => { DelButtonClick?.Invoke(this, EventArgs.Empty); };
            

            _delButton.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            
            this.Controls.Add(_title);
            this.Controls.Add(new Label()
            {
                Width = 10,
                Dock = DockStyle.Right
            });
            this.Controls.Add(_delButton);
            this.Controls.Add(new Label()
            {
                Width = 10,
                Dock =  DockStyle.Right
            });

            this.BorderStyle = BorderStyle.FixedSingle;




            BackColor = Color.CadetBlue;
            Height = 32;
            Margin = new Padding(10);

            Anchor = AnchorStyles.Left;
            Dock = DockStyle.Top;
        }



    }
}