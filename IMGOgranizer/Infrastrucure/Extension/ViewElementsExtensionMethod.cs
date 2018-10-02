using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMGOgranizer.ViewControl;

namespace IMGOgranizer.Extension
{
    public static class ViewElementsExtensionMethod
    {
        public static void AddToList(this Button bt, string text)
        {
            ViewElementsControl.ListOfElements.Add(text, bt);
        }

        public static void AddToList(this TextBox bt, string text)
        {
            ViewElementsControl.ListOfElements.Add(text, bt);
        }

        public static void AddToList(this RichTextBox bt, string text)
        {
            ViewElementsControl.ListOfElements.Add(text, bt);
        }

        public static void AddToList(this RadioButton bt, string text)
        {
            ViewElementsControl.ListOfElements.Add(text, bt);
        }
    }
}
