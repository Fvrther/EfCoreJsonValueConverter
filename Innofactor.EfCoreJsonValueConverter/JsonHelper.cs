using Newtonsoft.Json;

namespace Innofactor.EfCoreJsonValueConverter {

  internal static class JsonHelper {

    public static T Deserialize<T>(string json) {
      return string.IsNullOrWhiteSpace(json) ? default(T) : JsonConvert.DeserializeObject<T>(json);
    }

    public static string Serialize<T>(T obj) {
      return obj == null ? null : JsonConvert.SerializeObject(obj);
    }

  }

}
