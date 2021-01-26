namespace MgSoft.Import
{
    internal interface IImportComponent
    {
        string Name { get; }
        string Title { get; }
        string Describe { get; }
        string TargetConfigName { get; }
    }
}