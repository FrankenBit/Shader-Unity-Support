using System.ComponentModel.Composition;

using Microsoft.VisualStudio.Utilities;

namespace ShaderContentType
{
    internal static class FileAndContentTypeDefinitions
    {
        [Export]
        [Name("cgshader")]
        [BaseDefinition("C/C++")]
        internal static ContentTypeDefinition hidingContentTypeDefinition = default;

        [Export]
        [FileExtension(".shader")]
        [ContentType("cgshader")]
        internal static FileExtensionToContentTypeDefinition shaderFileExtensionDefinition = default;

        [Export]
        [FileExtension(".cginc")]
        [ContentType("cgshader")]
        internal static FileExtensionToContentTypeDefinition cgincFileExtensionDefinition = default;

        [Export]
        [FileExtension(".compute")]
        [ContentType("cgshader")]
        internal static FileExtensionToContentTypeDefinition shaderFileExtensionDefinitionForCompute = default;
    }
}