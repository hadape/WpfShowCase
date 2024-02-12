namespace NhlPlayers.Infrastructure
{
    public interface IInfrastrucutreSetting
    {
        string ImportFolder { get; set; }
        string ExportFolder { get; set; }
        string ImportPath { get; }
        string ExportPath { get; }
        string FileTypeFilter { get; set; }
        string ExportFileTemplate { get; set; }
    }
}
