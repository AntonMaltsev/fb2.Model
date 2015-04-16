namespace fb2.Model.Description
{
    using System.Xml.Serialization;

    using fb2.Model.Types;
    using fb2.Model.Types.Data;

    /// <summary>
    ///     The fiction book description custominfo.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookDescriptionCustominfo : TextFieldType
    {
        /// <summary>
        ///     The infotype field.
        /// </summary>
        private string infotypeField;

        /// <summary>
        ///     The infotype.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute("info-type")]
        public string infotype
        {
            get
            {
                return this.infotypeField;
            }

            set
            {
                this.infotypeField = value;
            }
        }
    }
}