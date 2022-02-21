namespace ToolLibrary
{
    internal class ToolData
    {
        public string toolname;
        public string tooldescription;
        public int storage;

        public string ToolName
        {
            get { return toolname; }
        }

        public string ToolDescription
        {
            get { return tooldescription; }
        }

        public int Storage
        {
            get { return storage; }
        }

        public ToolData(string ToolName, string ToolDescription, int Storage)
        {
            this.toolname = ToolName;
            this.tooldescription = ToolDescription;
            this.storage = Storage;
        }

        public override string ToString()
        {
            return (toolname + " |" + tooldescription + "| " + storage.ToString() + "\n");
        }
    }
}