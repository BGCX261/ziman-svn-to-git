using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace KBOBase
{
    public class EmptyBase : KBOBase.BaseInterface

    {
        List<KBOClass> classes;

        public List<KBOClass> Classes
        {
            get { return classes; }
            set { classes = value; }
        }

        List<KBOEntity> entities;

        public List<KBOBase.KBOEntity> Entities
        {
            get { return entities; }
            set { entities = value; }
        }

        List<KBOAttribute> attributes;

        public List<KBOAttribute> Attributes
        {
            get { return attributes; }
            set { attributes = value; }
        }

        List<KBOAttributeType> attributeTypes;

        public List<KBOAttributeType> AttributeTypes
        {
            get { return attributeTypes; }
            set { attributeTypes = value; }
        }

        List<KBORelation> reletions;

        public List<KBORelation> Reletions
        {
            get { return reletions; }
            set { reletions = value; }
        }

        List<KBORelationType> reletionTypes;

        public List<KBORelationType> ReletionTypes
        {
            get { return reletionTypes; }
            set { reletionTypes = value; }
        }

        Boolean isConnected = false;
        
        public string connect(object param)
        {
            
            Classes = new List<KBOClass>();
            Entities = new List<KBOEntity>();
            Attributes = new List<KBOAttribute>();
            AttributeTypes = new List<KBOAttributeType>();
            Reletions = new List<KBORelation>();
            ReletionTypes = new List<KBORelationType>();

            isConnected = true;

            return "connection string";
        }

        public void load(object param)
        {
            
        }

        public void save(object param)
        {
            
        }
    }
}
