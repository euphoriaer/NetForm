using Data;

namespace InterfacePlugIn
{
	public interface Export
	{
		public string Name { get; set; }

		public void OutputFile(string FilePath, DesignerData data);
	}
}