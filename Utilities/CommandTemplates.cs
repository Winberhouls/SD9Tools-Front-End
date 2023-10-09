using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sd9tool_front_end.Utilities
{
    internal static class CommandTemplates
    {
        public static IDictionary<string, string> Commands = new Dictionary<string, string>
        {
            { CommandKeys.ANALIZE, "\"{script_path}\" -f \"{filePath}\" -p" },
            { CommandKeys.OUTPUT, "\"{script_path}\" -f \"{filePath}\" --outfile " },
        };

        public static string CreateCommand(string commandKey, IDictionary<string, string> variables)
        {
            if (!Commands.ContainsKey(commandKey)) throw new InvalidOperationException("No existe el comando");

            var builder = new StringBuilder(Commands[commandKey]);
            foreach ( var key in variables.Keys)
            {
                builder.Replace($"{{{key}}}", variables[key]);
            }

            return builder.ToString();
        }
    }
}
