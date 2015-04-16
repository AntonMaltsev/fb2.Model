namespace fb2.Model.Types.Formating
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The p type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class PType : StyleType
    {
        /// <summary>
        ///     The id field.
        /// </summary>
        private string idField;

        /// <summary>
        ///     The style field.
        /// </summary>
        private string styleField;

        /// <summary>
        ///     The id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute(DataType = "ID")]
        public string id
        {
            get
            {
                return this.idField;
            }

            set
            {
                this.idField = value;
            }
        }

        /// <summary>
        ///     The style.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute]
        public string style
        {
            get
            {
                return this.styleField;
            }

            set
            {
                this.styleField = value;
            }
        }
    }
}