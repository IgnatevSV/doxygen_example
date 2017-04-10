using System.Collections.Generic;
using System.Xml.Serialization;

namespace DialogueSystemScripts.Models
{
    /** \addtogroup XML_Models
    *  @{
        */
    
    /// <summary>
    /// Класс, содержащий коллекцию настроек диалогов из XML.
    /// </summary>
    [XmlRoot("main")]
    public class XML_DialoguesCollection
    {
        /// <summary>
        /// Коллекция настроек диалогов из XML.
        /// </summary>
        [XmlArray("dialogues")]
        [XmlArrayItem("dialogue")]
        public List<XML_DialogueSettings> Dialogues
        {
            private set;
            get;
        }
    }
    /** @}*/
}