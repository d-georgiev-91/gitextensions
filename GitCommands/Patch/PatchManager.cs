            if (body != null && "true".Equals(module.GetEffectiveSetting("core.autocrlf"), StringComparison.InvariantCultureIgnoreCase))
            if (reset && body != null && "true".Equals(module.GetEffectiveSetting("core.autocrlf"), StringComparison.InvariantCultureIgnoreCase))
            var s = new System.Text.StringBuilder();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
                result = result.Combine("\n", Application.ProductName + " " + Settings.GitExtensionsVersionString);