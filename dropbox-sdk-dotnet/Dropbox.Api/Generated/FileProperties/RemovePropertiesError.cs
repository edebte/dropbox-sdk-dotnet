// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.FileProperties
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The remove properties error object</para>
    /// </summary>
    public class RemovePropertiesError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RemovePropertiesError> Encoder = new RemovePropertiesErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RemovePropertiesError> Decoder = new RemovePropertiesErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RemovePropertiesError" />
        /// class.</para>
        /// </summary>
        public RemovePropertiesError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is PropertyGroupLookup</para>
        /// </summary>
        public bool IsPropertyGroupLookup
        {
            get
            {
                return this is PropertyGroupLookup;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a PropertyGroupLookup, or <c>null</c>.</para>
        /// </summary>
        public PropertyGroupLookup AsPropertyGroupLookup
        {
            get
            {
                return this as PropertyGroupLookup;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Path</para>
        /// </summary>
        public bool IsPath
        {
            get
            {
                return this is Path;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Path, or <c>null</c>.</para>
        /// </summary>
        public Path AsPath
        {
            get
            {
                return this as Path;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UnsupportedFolder</para>
        /// </summary>
        public bool IsUnsupportedFolder
        {
            get
            {
                return this is UnsupportedFolder;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UnsupportedFolder, or <c>null</c>.</para>
        /// </summary>
        public UnsupportedFolder AsUnsupportedFolder
        {
            get
            {
                return this as UnsupportedFolder;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RemovePropertiesError" />.</para>
        /// </summary>
        private class RemovePropertiesErrorEncoder : enc.StructEncoder<RemovePropertiesError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RemovePropertiesError value, enc.IJsonWriter writer)
            {
                if (value is PropertyGroupLookup)
                {
                    WriteProperty(".tag", "property_group_lookup", writer, enc.StringEncoder.Instance);
                    PropertyGroupLookup.Encoder.EncodeFields((PropertyGroupLookup)value, writer);
                    return;
                }
                if (value is Path)
                {
                    WriteProperty(".tag", "path", writer, enc.StringEncoder.Instance);
                    Path.Encoder.EncodeFields((Path)value, writer);
                    return;
                }
                if (value is UnsupportedFolder)
                {
                    WriteProperty(".tag", "unsupported_folder", writer, enc.StringEncoder.Instance);
                    UnsupportedFolder.Encoder.EncodeFields((UnsupportedFolder)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RemovePropertiesError" />.</para>
        /// </summary>
        private class RemovePropertiesErrorDecoder : enc.UnionDecoder<RemovePropertiesError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RemovePropertiesError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RemovePropertiesError Create()
            {
                return new RemovePropertiesError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override RemovePropertiesError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "property_group_lookup":
                        return PropertyGroupLookup.Decoder.DecodeFields(reader);
                    case "path":
                        return Path.Decoder.DecodeFields(reader);
                    case "unsupported_folder":
                        return UnsupportedFolder.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The property group lookup object</para>
        /// </summary>
        public sealed class PropertyGroupLookup : RemovePropertiesError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<PropertyGroupLookup> Encoder = new PropertyGroupLookupEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<PropertyGroupLookup> Decoder = new PropertyGroupLookupDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PropertyGroupLookup" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public PropertyGroupLookup(LookUpPropertiesError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PropertyGroupLookup" />
            /// class.</para>
            /// </summary>
            private PropertyGroupLookup()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public LookUpPropertiesError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="PropertyGroupLookup" />.</para>
            /// </summary>
            private class PropertyGroupLookupEncoder : enc.StructEncoder<PropertyGroupLookup>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(PropertyGroupLookup value, enc.IJsonWriter writer)
                {
                    global::Dropbox.Api.FileProperties.LookUpPropertiesError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="PropertyGroupLookup" />.</para>
            /// </summary>
            private class PropertyGroupLookupDecoder : enc.StructDecoder<PropertyGroupLookup>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="PropertyGroupLookup"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override PropertyGroupLookup Create()
                {
                    return new PropertyGroupLookup();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(PropertyGroupLookup value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "property_group_lookup":
                            value.Value = global::Dropbox.Api.FileProperties.LookUpPropertiesError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The path object</para>
        /// </summary>
        public sealed class Path : RemovePropertiesError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Path> Encoder = new PathEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Path> Decoder = new PathDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Path" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Path(LookupError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Path" /> class.</para>
            /// </summary>
            private Path()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public LookupError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Path" />.</para>
            /// </summary>
            private class PathEncoder : enc.StructEncoder<Path>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Path value, enc.IJsonWriter writer)
                {
                    global::Dropbox.Api.FileProperties.LookupError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Path" />.</para>
            /// </summary>
            private class PathDecoder : enc.StructDecoder<Path>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Path" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Path Create()
                {
                    return new Path();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(Path value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "path":
                            value.Value = global::Dropbox.Api.FileProperties.LookupError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>This folder cannot be tagged. Tagging folders is not supported for team-owned
        /// templates.</para>
        /// </summary>
        public sealed class UnsupportedFolder : RemovePropertiesError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UnsupportedFolder> Encoder = new UnsupportedFolderEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UnsupportedFolder> Decoder = new UnsupportedFolderDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UnsupportedFolder" />
            /// class.</para>
            /// </summary>
            private UnsupportedFolder()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UnsupportedFolder</para>
            /// </summary>
            public static readonly UnsupportedFolder Instance = new UnsupportedFolder();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UnsupportedFolder" />.</para>
            /// </summary>
            private class UnsupportedFolderEncoder : enc.StructEncoder<UnsupportedFolder>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UnsupportedFolder value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UnsupportedFolder" />.</para>
            /// </summary>
            private class UnsupportedFolderDecoder : enc.StructDecoder<UnsupportedFolder>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UnsupportedFolder"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UnsupportedFolder Create()
                {
                    return UnsupportedFolder.Instance;
                }

            }

            #endregion
        }
    }
}
