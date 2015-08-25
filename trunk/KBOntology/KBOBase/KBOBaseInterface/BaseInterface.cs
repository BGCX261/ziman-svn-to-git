using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KBOBase
{
    public interface BaseInterface
    {
        /// <summary>
        /// Подключение к базе
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        String connect(Object param);

        void load(Object param);

        void save(Object param);


        List<KBOClass> Classes { get; set; }
        List<KBOBase.KBOEntity> Entities { get; set; }
        List<KBOAttribute> Attributes { get; set; }
        List<KBOAttributeType> AttributeTypes { get; set; }
        List<KBORelation> Reletions { get; set; }
        List<KBORelationType> ReletionTypes { get; set; }


    }
}
