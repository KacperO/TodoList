using System.Windows.Forms;

namespace TodoList.Util
{
    public class TextBoxValidate
    {
        public bool Validate(TextBox textBox)
        {
            return !string.IsNullOrEmpty(textBox.Text);
        }
    }
}
