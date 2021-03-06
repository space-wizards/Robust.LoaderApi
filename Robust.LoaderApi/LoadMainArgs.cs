namespace Robust.LoaderApi
{
    /// <summary>
    ///     Contains various thing that the loader needs to communicate to the engine.
    /// </summary>
    public interface IMainArgs
    {
        /// <summary>
        ///     Command line arguments to pass to the engine.
        /// </summary>
        string[] Args { get; }

        /// <summary>
        ///     File API usable to read files from the engine's installation directory.
        /// </summary>
        IFileApi FileApi { get; }
    }
}
