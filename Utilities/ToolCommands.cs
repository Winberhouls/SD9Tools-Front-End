using System.Diagnostics;

namespace sd9tool_front_end.Utilities
{
    internal static class ToolCommands
    {
        internal static string EjecutarComando(string comando, string argumentos)
        {
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = comando;
            p.StartInfo.Arguments = argumentos;
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            return output;
        }
    }
}
