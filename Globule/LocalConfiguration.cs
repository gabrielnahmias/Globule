using System.Configuration;

public class LocalConfiguration
{
	public Configuration GetConfig(string Path)
	{

		Configuration retVal;

		ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();

		configFileMap.ExeConfigFilename = Path;

		retVal = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

		return retVal;

	}
	
}