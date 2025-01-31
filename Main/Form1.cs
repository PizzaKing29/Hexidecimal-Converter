namespace Main;

#pragma warning restore format

public partial class Form1 : Form
{

    private Label labelDecimal;
    private TextBox textBoxDecimal;
    private Button buttonConvert;
    private Label labelHex;
    private TextBox textBoxHex;


    public Form1()
    {

        // Form Properties
        this.Text = "Decimal to Hex Converter";
        this.Width = 300;
        this.Height = 200;
        
        // Decimal Input Label
        labelDecimal = new Label();
        labelDecimal.Text = "Enter Decimal:";
        labelDecimal.Location = new System.Drawing.Point(20, 20);
        labelDecimal.AutoSize = true;
        this.Controls.Add(labelDecimal);

        // Decimal Input TextBox
        textBoxDecimal = new TextBox();
        textBoxDecimal.Location = new System.Drawing.Point(120, 18);
        textBoxDecimal.Width = 100;
        this.Controls.Add(textBoxDecimal);

        // Convert Button
        buttonConvert = new Button();
        buttonConvert.Text = "Convert";
        buttonConvert.Location = new System.Drawing.Point(20, 60);
        buttonConvert.Click += ButtonConvert_Click;
        this.Controls.Add(buttonConvert);

        // Hexadecimal Output Label
        labelHex = new Label();
        labelHex.Text = "Hexadecimal:";
        labelHex.Location = new System.Drawing.Point(20, 100);
        labelHex.AutoSize = true;
        this.Controls.Add(labelHex);

        // Hexadecimal Output TextBox
        textBoxHex = new TextBox();
        textBoxHex.Location = new System.Drawing.Point(120, 98);
        textBoxHex.Width = 100;
        textBoxHex.ReadOnly = true;
        this.Controls.Add(textBoxHex);
        
        InitializeComponent();
    }

    private void ButtonConvert_Click(object sender, EventArgs e)
    {
        int inputDecimal = int.Parse(textBoxDecimal.Text);
        string hex = "";

        while (inputDecimal > 0)
        {
            int remainder = inputDecimal % 16;
            hex = remainder.ToString("X") + hex;
            inputDecimal /= 16;


        }
        textBoxHex.Text = hex;
    }
}
