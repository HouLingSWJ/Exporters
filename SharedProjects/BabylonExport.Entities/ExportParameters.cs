using Utilities;
using GLTFExport.Entities;

namespace BabylonExport.Entities
{
    // Define the policy use to assign format to aggregated texture such ORM
    public enum TextureFormatExportPolicy
    {
        QUALITY, // we want the best quality
        CONSERVATIV, // we try to keep the source format if possible
        SIZE // we try to minimize the size of texture as much as possibe.
    }

    public class ExportParameters
    {
        public string softwarePackageName;
        public string softwareVersion;
        public string exporterVersion;
        public string outputPath; // The directory to store the generated files
        public string outputFormat;
        public string textureFolder;
        public float scaleFactor = 1.0f;
        public bool writeTextures = true;
        public bool overwriteTextures = true;
        public bool exportHiddenObjects = false;
        public bool exportMaterials = true;
        public bool exportOnlySelected = false;
        public bool bakeAnimationFrames = false;
        public bool optimizeAnimations = true;
        public bool optimizeVertices = true;
        public bool animgroupExportNonAnimated = false;
        public bool generateManifest = false;
        public bool autoSaveSceneFile = false;
        public bool exportTangents = true;
        public bool exportSkins = true;
        public bool exportMorphTangents = true;
        public bool exportMorphNormals = true;
        public long txtQuality = 100;
        public bool mergeAOwithMR = true;
        public bool dracoCompression = false;
        public bool enableKHRLightsPunctual = false;
        public bool enableKHRTextureTransform = false;
        public bool enableKHRMaterialsUnlit = false;
        public bool pbrFull = false;
        public bool pbrNoLight = false;
        public bool createDefaultSkybox = false;
        public string pbrEnvironment;
        public bool exportAnimations = true;
        public bool exportAnimationsOnly = false;
        public bool exportTextures = true;
        // try to optimize the output reu-sing opaque and blend texture.
        public bool tryToReuseOpaqueAndBlendTexture = false;
        public TextureFormatExportPolicy textureFormatExportPolicy = TextureFormatExportPolicy.CONSERVATIV;


        public IGLTFMaterialExporter customGLTFMaterialExporter;
        public bool useMultiExporter = false;

        public const string ModelFilePathProperty = "modelFilePathProperty";
        public const string TextureFolderPathProperty = "textureFolderPathProperty";

        public const string PBRFullPropertyName = "babylonjs_pbr_full";
        public const string PBRNoLightPropertyName = "babylonjs_pbr_nolight";
        public const string PBREnvironmentPathPropertyName = "babylonjs_pbr_environmentPathProperty";
    }
}
