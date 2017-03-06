namespace Photo_SorterWP.Model
{
    class PhotoModel
    {
        private readonly string name;
        private readonly string path;
        private readonly string creationTime;
        private readonly string modificationTime;
        private readonly string size;
        private readonly string extansion;
        //private readonly string cameraModel;


        public PhotoModel(string name, string path, string creationTime, string modificationTime, string size, string extansion)
        {
            this.name = name;
            this.path = path;
            this.creationTime = creationTime;
            this.modificationTime = modificationTime;
            this.size = size;
            this.extansion = extansion;
        }

        public string Name
        {
            get { return name; }
        }

        public string Path
        {
            get { return path; }
        }

        public string CreationTime
        {
            get { return creationTime; }
        }

        public string ModificationTime
        {
            get { return modificationTime; }
        }

        public string Size
        {
            get { return size; }
        }

        public string Extansion
        {
            get { return extansion; }
        }
    }
}