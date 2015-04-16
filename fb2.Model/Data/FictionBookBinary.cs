namespace fb2.Model.Data
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The fiction book binary.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookBinary
    {
        /// <summary>
        ///     The contenttype field.
        /// </summary>
        private string contenttypeField;

        /// <summary>
        ///     The id field.
        /// </summary>
        private string idField;

        /// <summary>
        ///     The value field.
        /// </summary>
        private byte[] valueField;

        /// <summary>
        ///     The contenttype.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute("content-type")]
        public string contenttype
        {
            get
            {
                return this.contenttypeField;
            }

            set
            {
                this.contenttypeField = value;
            }
        }

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
        ///     The value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlText(DataType = "base64Binary")]
        public byte[] Value
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