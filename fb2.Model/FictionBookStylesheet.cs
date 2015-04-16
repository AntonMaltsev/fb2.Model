namespace fb2.Model
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The fiction book stylesheet.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookStylesheet
    {
        /// <summary>
        ///     The type field.
        /// </summary>
        private string typeField;

        /// <summary>
        ///     The value field.
        /// </summary>
        private string valueField;

        /// <summary>
        ///     The type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute]
        public string type
        {
            get
            {
                return this.typeField;
            }

            set
            {
                this.typeField = value;
            }
        }

        /// <summary>
        ///     The value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlText]
        public string Value
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