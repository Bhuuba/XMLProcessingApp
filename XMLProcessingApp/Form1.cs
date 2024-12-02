using System.Xml.Linq;

namespace XMLProcessingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                    LoadAttributes(txtFilePath.Text);
                }
            }
        }

        private void LoadAttributes(string filePath)
        {
            var document = XDocument.Load(filePath);
            var attributes = document.Descendants("book")
                .Attributes()
                .Select(a => a.Name.LocalName)
                .Distinct();
            cmbAttributes.Items.Clear();
            cmbAttributes.Items.AddRange(attributes.ToArray());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbAttributes.SelectedItem == null || string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("������� ������� �� ������ ������� ����� ��� ������.");
                return;
            }

            string attributeName = cmbAttributes.SelectedItem.ToString();
            string keyword = txtSearch.Text;

            var document = XDocument.Load(txtFilePath.Text);
            var results = document.Descendants("book")
                .Where(e => e.Attribute(attributeName)?.Value.Contains(keyword) == true)
                .Select(e => e.ToString());

            rtbOutput.Clear();
            foreach (var result in results)
            {
                rtbOutput.AppendText(result + Environment.NewLine);
            }

            if (!results.Any())
            {
                rtbOutput.AppendText("ͳ���� �� ��������.");
            }
        }
        private void BtnTransformToHtml_Click(object sender, EventArgs e)
        {
            XmlProcessor processor = new XmlProcessor();

            // ����� �����
            string xmlPath = "library.xml";
            string xslPath = "transform.xsl";

            // �������� HTML
            string outputHtmlPath = "output.html";

            // ������ �������������
            processor.TransformXmlToHtml(xmlPath, xslPath, outputHtmlPath);

            MessageBox.Show("������������� ���������! �������� ���� output.html.");
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            string xmlPath = txtFilePath.Text;
            string xslPath = "transform.xsl";
            string htmlPath = "output.html";

            if (string.IsNullOrWhiteSpace(xmlPath))
            {
                MessageBox.Show("���������� XML-���� ����� ��������������.");
                return;
            }

            try
            {
                var xslt = new System.Xml.Xsl.XslCompiledTransform();
                xslt.Load(xslPath);
                xslt.Transform(xmlPath, htmlPath);
                MessageBox.Show($"HTML-���� ��������: {htmlPath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ��� �������������: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("�� ����� �� ������ ��������� ������ � ���������?", "�����", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
