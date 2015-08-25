using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KBOBase
{
    /// <remarks>Объекты KBOClass хранятся самостоятельно.</remarks>
    public class KBOClass
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        String id;
        String parentId;
        String name;
        Object description;

        static String thisId = "This";

        public static String ThisId
        {
            get { return KBOClass.thisId; }

        }

        /// <summary>
        /// Конструктор класса KBOClass
        /// </summary>
        /// <param name="ClassId"></param>
        /// <param name="ParentClassId"></param>
        /// <param name="ClassName"></param>
        /// <param name="ClassDescription"></param>
        public KBOClass(String ClassName = null, String ClassId = null, String ParentClassId = null, Object ClassDescription = null)
        {
            this.Id = ClassId;
            this.ParentId = ParentClassId;
            this.Name = ClassName;
            this.Description = ClassDescription;
        }

        /// <summary>
        /// Описание класса
        /// </summary>
        public Object Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Идентификатор родителя класса
        /// </summary>
        public String ParentId
        {
            get { return this.parentId; }
            set { if (value != null) { this.parentId = value; } else { this.parentId = ThisId; } }
        }

        /// <summary>
        /// Имя класса
        /// </summary>
        public String Name
        {
            get { return this.name; }
            set { if (value != null) { this.name = value; } else { this.name = "none"; } }
        }

        /// <summary>
        /// Идентификатор класса
        /// </summary>
        public System.String Id
        {
            get { return this.id; }
            set { if (value != null) { this.id = value; } else { this.id = Convert.ToString(Guid.NewGuid()); } }
        }
    }

    /// <remarks>Объекты KBOEntity хранятся самостоятельно.</remarks>
    public class KBOEntity
    {
        String id;
        public String Id
        {
            get { return this.id; }
            set { if (value != null) { this.id = value; } else { this.id = Convert.ToString(Guid.NewGuid()); } }
        }

        String name;
        public String Name
        {
            get { return this.name; }
            set { if (value != null) { this.name = value; } else { this.name = "none"; } }
        }

        Object description;
        public Object Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public KBOEntity(String EntityId = "", String EntityName = null, List<KBOAttribute> EntityAttributes = null, List<KBORelation> EntityRelations = null, Object EntityDescription = null)
        {
            this.Id = EntityId;
            this.Name = EntityName;
            this.Description = EntityDescription;
        }


    }

    /// <remarks>Объекты KBOAttribute хранятся самостоятельно.</remarks>
    public class KBOAttribute
    {
        String id;

        public String Id
        {
            get { return this.id; }
            set { if (value != null) { this.id = value; } else { this.id = Convert.ToString(Guid.NewGuid()); } }
        }
        String typeId;

        public String TypeId
        {
            get { return this.typeId; }
            set { if (value != null) { this.typeId = value; } else { throw new ArgumentNullException("KBOAttribute. Недопустимое значение TypeId: null"); } }
        }
        Object value;

        public Object Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public KBOAttribute(String AttributeTypeId, String AttributeId = null, Object AttributeValue = null)
        {
            this.Id = AttributeId;
            this.TypeId = AttributeTypeId;
            this.Value = AttributeValue;
        }
    }

    /// <remarks>Объекты KBOAttributeType хранятся самостоятельно.</remarks>
    public class KBOAttributeType
    {
        String id;

        public String Id
        {
            get { return this.id; }
            set { if (value != null) { this.id = value; } else { this.id = Convert.ToString(Guid.NewGuid()); } }
        }
        String name;

        public String Name
        {
            get { return this.name; }
            set { if (value != null) { this.name = value; } else { this.name = "none"; } }
        }
        Object description;

        public Object Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public KBOAttributeType(String AttributeTypeId = null, String AttributeTypeName = null, Object AttributeTypeDescription = null)
        {
            this.Id = AttributeTypeId;
            this.Name = AttributeTypeName;
            this.Description = AttributeTypeDescription;
        }
    }

    /// <remarks>Объекты KBORelation хранятся самостоятельно.</remarks>
    public class KBORelation
    {
        String id;
        public String Id
        {
            get { return this.id; }
            set { if (value != null) { this.id = value; } else { this.id = Convert.ToString(Guid.NewGuid()); } }
        }

        String typeId;
        public String TypeId
        {
            get { return this.typeId; }
            set { if (value != null) { this.typeId = value; } else { throw new ArgumentNullException("KBORelation. Недопустимое значение TypeId: null"); } }
        }

        String destinationId;
        public String DestinationId
        {
            get { return this.destinationId; }
            set { if (value != null) { this.destinationId = value; } else { throw new ArgumentNullException("KBORelation. Недопустимое значение DestinationId: null"); } }
        }

        String addresserId;
        public String AddresserId
        {
            get { return this.addresserId; }
            set { if (value != null) { this.addresserId = value; } else { throw new ArgumentNullException("KBORelation. Недопустимое значение AddresserId: null"); } }
        }

        public KBORelation(String RelationTypeId, String RelationDestinationId, String RelationAddresserId, String RelationId = null)
        {
            this.Id = RelationId;
            this.TypeId = RelationTypeId;
            this.DestinationId = RelationDestinationId;
            this.AddresserId = RelationAddresserId;
        }
    }

    /// <remarks>Объекты KBORelationType хранятся самостоятельно.</remarks>
    public class KBORelationType
    {
        String id;

        public String Id
        {
            get { return this.id; }
            set { if (value != null) { this.id = value; } else { this.id = Convert.ToString(Guid.NewGuid()); } }
        }

        String name;

        public String Name
        {
            get { return this.name; }
            set { if (value != null) { this.name = value; } else { this.name = "none"; } }
        }

        Object description;

        public Object Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public KBORelationType(String RelationTypeName, String RelationTypeId = null, Object RelationTypeDescription = null)
        {
            this.Id = RelationTypeId;
            this.Name = RelationTypeName;
            this.Description = RelationTypeDescription;
        }
    }
}
