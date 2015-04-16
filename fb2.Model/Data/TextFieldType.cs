namespace fb2.Model.Data
{
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using fb2.Model.Base;

    /// <summary>
    ///     The text field type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class TextFieldType : BaseTextData
    {
        /// <summary>
        ///     The lang field.
        /// </summary>
        private string langField;

        /// <summary>
        ///     The value field.
        /// </summary>
        private string valueField;

        /// <summary>
        ///     The lang.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }

            set
            {
                this.langField = value;
            }
        }

        /// <summary>
        /// The value.
        /// </summary>
        /// <value>
        /// The Value.
        /// </value>
        [XmlText]
        public override string Text
        {
            get
            {
                return this.valueField;
            }

            set
            {
                this.valueField = value;
            }
        }
    }
}