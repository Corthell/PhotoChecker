using IMGOgranizer.Infrastrucure;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IMGOgranizer.ViewControl
{
    public static class ViewElementsControl
    {
        /// <summary>
        /// Register list of elements.
        /// </summary>.
        public static Dictionary<string, Control> ListOfElements { get; set; }
        static ViewElementsControl()
        {
            ListOfElements = new Dictionary<string, Control>();
        }
        //
        // Enables and Disables operations
        //
        /// <summary>
        /// Enables or disables items by the name specified in the parameter.
        /// </summary>
        /// <param name="onOff">if set to <c>true</c> the item will be turned on.</param>
        /// <param name="elementName">Value of the Name property of this element.</param>
        public static void OnOffElementsByName(bool onOff, params string[] elementName)
        {
            foreach (var item in elementName)
            {
                if (ListOfElements.ContainsKey(item))
                    ListOfElements[item].Enabled = onOff;
                else
                    MessageBox.Show($@"Control ""{item}"" is missing in registry!");
            }
        }

        /// <summary>
        /// Enables or disables all the elements of the type specified in the parameter.
        /// </summary>
        /// <param name="onOff">if set to <c>true</c> the item will be turned on.</param>
        /// <param name="elementsType">The type element specified in the ElementsType enum.</param>
        public static void OnOffAllElementsOfType(bool onOff, ElementsType elementsType)
        {
            switch (elementsType)
            {
                case ElementsType.Button:
                    {
                        foreach (var item in ListOfElements.Values)
                        {
                            if (item.GetType() == typeof(Button))
                                item.Enabled = onOff;
                        }

                        break;
                    }
                case ElementsType.TextBox:
                    {
                        foreach (var item in ListOfElements.Values)
                        {
                            if (item.GetType() == typeof(TextBox))
                                item.Enabled = onOff;
                        }

                        break;
                    }
                case ElementsType.RichTextBox:
                    {
                        foreach (var item in ListOfElements.Values)
                        {
                            if (item.GetType() == typeof(RichTextBox))
                                item.Enabled = onOff;
                        }

                        break;
                    }
                case ElementsType.RadioButton:
                    {
                        foreach (var item in ListOfElements.Values)
                        {
                            if (item.GetType() == typeof(RadioButton))
                                item.Enabled = onOff;
                        }

                        break;
                    }
                default:
                    {
                        MessageBox.Show(@"This control is not supported!");
                        break;
                    }

            }
        }

        /// <summary>
        /// Enables or disables all the registered elements.
        /// </summary>
        /// <param name="onOff">if set to <c>true</c> the item will be turned on.</param>
        public static void OnOffAllElements(bool onOff)
        {
            foreach (var item in ListOfElements.Values)
            {
                item.Enabled = onOff;
            }
        }
        //
        // Clear Operations
        //
        /// <summary>
        /// Clear value of the Text property of items by the name specified in the parameter.
        /// </summary>
        /// <param name="elementName">Value of the Name property of this element.</param>
        public static void ClearTextValueOfElementsByName(params string[] elementName)
        {
            foreach (var item in elementName)
            {
                if (ListOfElements.ContainsKey(item))
                    ListOfElements[item].Text = String.Empty;
                else
                    MessageBox.Show($@"Control ""{item}"" is missing in registry!");
            }
        }

        /// <summary>
        /// Clear value of the Text property of items by the type specified in the parameter.
        /// </summary>
        /// <param name="elementsType">The type element specified in the ElementsType enum.</param>
        public static void ClearTextValueOfElementsOfType(ElementsType elementsType)
        {
            switch (elementsType)
            {
                case ElementsType.TextBox:
                    {
                        foreach (var item in ListOfElements.Values)
                        {
                            if (item.GetType() == typeof(TextBox))
                                item.Text = String.Empty;
                        }

                        break;
                    }
                case ElementsType.RichTextBox:
                    {
                        foreach (var item in ListOfElements.Values)
                        {
                            if (item.GetType() == typeof(RichTextBox))
                                item.Text = String.Empty;
                        }

                        break;
                    }
                default:
                    {
                        MessageBox.Show(@"This control is not supported!");
                        break;
                    }

            }
        }

        /// <summary>
        /// Clear value of the Text property of all allowed items.
        /// </summary>
        public static void ClearTextValueOfAllElements()
        {
            foreach (var item in ListOfElements.Values)
            {
                if (item.GetType() == typeof(TextBox) || item.GetType() == typeof(RichTextBox))
                    item.Text = String.Empty;
            }
        }
    }
}
