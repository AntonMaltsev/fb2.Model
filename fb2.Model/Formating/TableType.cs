namespace fb2.Model.Formating
{
    using System.Xml.Serialization;

    using fb2.Model.Base;

    /// <summary>
    ///     The table type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class TableType : BaseFormatingStyle
    {
        /// <summary>
        ///     The tr field.
        /// </summary>
        private TableTypeTr[] trField;

        /// <summary>
        ///     The tr.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("tr")]
        public TableTypeTr[] tr
        {
            get
            {
                return this.trField;
            }

            set
            {
                this.trField = value;
            }
        }
    }
}