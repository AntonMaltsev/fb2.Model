namespace fb2.Model
{
    using System.Xml.Serialization;

    using fb2.Model.Description;

    /// <summary>
    ///     The fiction book description.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookDescription
    {
        /// <summary>
        ///     The titleinfo.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("title-info")]
        public FictionBookDescriptionTitleinfo titleinfo { get; set; }

        /// <summary>
        ///     The documentinfo.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("document-info")]
        public FictionBookDescriptionDocumentinfo documentinfo { get; set; }

        /// <summary>
        ///     The publishinfo.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("publish-info")]
        public FictionBookDescriptionPublishinfo publishinfo { get; set; }

        /// <summary>
        ///     The custominfo.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("custom-info")]
        public FictionBookDescriptionCustominfo[] custominfo { get; set; }
    }
}