// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>NodeTransformation</c> to a <see cref="CesiumOutputStream" />.  A <c>NodeTransformation</c> is a set of transformations to apply to a particular node in a 3D model.
    /// </summary>
    public class NodeTransformationCesiumWriter : CesiumPropertyWriter<NodeTransformationCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>translation</c> property.
        /// </summary>
        public const string TranslationPropertyName = "translation";

        /// <summary>
        /// The name of the <c>rotation</c> property.
        /// </summary>
        public const string RotationPropertyName = "rotation";

        /// <summary>
        /// The name of the <c>scale</c> property.
        /// </summary>
        public const string ScalePropertyName = "scale";

        private readonly Lazy<TranslationCesiumWriter> m_translation = new Lazy<TranslationCesiumWriter>(() => new TranslationCesiumWriter(TranslationPropertyName), false);
        private readonly Lazy<RotationCesiumWriter> m_rotation = new Lazy<RotationCesiumWriter>(() => new RotationCesiumWriter(RotationPropertyName), false);
        private readonly Lazy<ScaleCesiumWriter> m_scale = new Lazy<ScaleCesiumWriter>(() => new ScaleCesiumWriter(ScalePropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public NodeTransformationCesiumWriter(string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected NodeTransformationCesiumWriter(NodeTransformationCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc />
        public override NodeTransformationCesiumWriter Clone()
        {
            return new NodeTransformationCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <c>translation</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>translation</c> property defines the translation to apply to the model node.
        /// </summary>
        public TranslationCesiumWriter TranslationWriter
        {
            get { return m_translation.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>translation</c> property.  The <c>translation</c> property defines the translation to apply to the model node.
        /// </summary>
        public TranslationCesiumWriter OpenTranslationProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(TranslationWriter);
        }

        /// <summary>
        /// Writes a value for the <c>translation</c> property as a <c>cartesian</c> value.  The <c>translation</c> property specifies the translation to apply to the model node.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteTranslationProperty(Cartesian value)
        {
            using (var writer = OpenTranslationProperty())
            {
                writer.WriteCartesian(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>translation</c> property as a <c>cartesian</c> value.  The <c>translation</c> property specifies the translation to apply to the model node.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteTranslationProperty(IList<JulianDate> dates, IList<Cartesian> values)
        {
            using (var writer = OpenTranslationProperty())
            {
                writer.WriteCartesian(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>translation</c> property as a <c>cartesian</c> value.  The <c>translation</c> property specifies the translation to apply to the model node.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteTranslationProperty(IList<JulianDate> dates, IList<Cartesian> values, int startIndex, int length)
        {
            using (var writer = OpenTranslationProperty())
            {
                writer.WriteCartesian(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>translation</c> property as a <c>reference</c> value.  The <c>translation</c> property specifies the translation to apply to the model node.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteTranslationPropertyReference(Reference value)
        {
            using (var writer = OpenTranslationProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>translation</c> property as a <c>reference</c> value.  The <c>translation</c> property specifies the translation to apply to the model node.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteTranslationPropertyReference(string value)
        {
            using (var writer = OpenTranslationProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>translation</c> property as a <c>reference</c> value.  The <c>translation</c> property specifies the translation to apply to the model node.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteTranslationPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenTranslationProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>translation</c> property as a <c>reference</c> value.  The <c>translation</c> property specifies the translation to apply to the model node.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteTranslationPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenTranslationProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>rotation</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>rotation</c> property defines the rotation to apply to the model node.
        /// </summary>
        public RotationCesiumWriter RotationWriter
        {
            get { return m_rotation.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>rotation</c> property.  The <c>rotation</c> property defines the rotation to apply to the model node.
        /// </summary>
        public RotationCesiumWriter OpenRotationProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(RotationWriter);
        }

        /// <summary>
        /// Writes a value for the <c>rotation</c> property as a <c>unitQuaternion</c> value.  The <c>rotation</c> property specifies the rotation to apply to the model node.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteRotationProperty(UnitQuaternion value)
        {
            using (var writer = OpenRotationProperty())
            {
                writer.WriteUnitQuaternion(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>rotation</c> property as a <c>unitQuaternion</c> value.  The <c>rotation</c> property specifies the rotation to apply to the model node.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteRotationProperty(IList<JulianDate> dates, IList<UnitQuaternion> values)
        {
            using (var writer = OpenRotationProperty())
            {
                writer.WriteUnitQuaternion(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>rotation</c> property as a <c>unitQuaternion</c> value.  The <c>rotation</c> property specifies the rotation to apply to the model node.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteRotationProperty(IList<JulianDate> dates, IList<UnitQuaternion> values, int startIndex, int length)
        {
            using (var writer = OpenRotationProperty())
            {
                writer.WriteUnitQuaternion(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>rotation</c> property as a <c>reference</c> value.  The <c>rotation</c> property specifies the rotation to apply to the model node.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteRotationPropertyReference(Reference value)
        {
            using (var writer = OpenRotationProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>rotation</c> property as a <c>reference</c> value.  The <c>rotation</c> property specifies the rotation to apply to the model node.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteRotationPropertyReference(string value)
        {
            using (var writer = OpenRotationProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>rotation</c> property as a <c>reference</c> value.  The <c>rotation</c> property specifies the rotation to apply to the model node.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteRotationPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenRotationProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>rotation</c> property as a <c>reference</c> value.  The <c>rotation</c> property specifies the rotation to apply to the model node.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteRotationPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenRotationProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>scale</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>scale</c> property defines the scaling to apply to the model node.
        /// </summary>
        public ScaleCesiumWriter ScaleWriter
        {
            get { return m_scale.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>scale</c> property.  The <c>scale</c> property defines the scaling to apply to the model node.
        /// </summary>
        public ScaleCesiumWriter OpenScaleProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ScaleWriter);
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>cartesian</c> value.  The <c>scale</c> property specifies the scaling to apply to the model node.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteScaleProperty(Cartesian value)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteCartesian(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>cartesian</c> value.  The <c>scale</c> property specifies the scaling to apply to the model node.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteScaleProperty(IList<JulianDate> dates, IList<Cartesian> values)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteCartesian(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>cartesian</c> value.  The <c>scale</c> property specifies the scaling to apply to the model node.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteScaleProperty(IList<JulianDate> dates, IList<Cartesian> values, int startIndex, int length)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteCartesian(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>reference</c> value.  The <c>scale</c> property specifies the scaling to apply to the model node.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteScalePropertyReference(Reference value)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>reference</c> value.  The <c>scale</c> property specifies the scaling to apply to the model node.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteScalePropertyReference(string value)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>reference</c> value.  The <c>scale</c> property specifies the scaling to apply to the model node.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteScalePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>scale</c> property as a <c>reference</c> value.  The <c>scale</c> property specifies the scaling to apply to the model node.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteScalePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenScaleProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

    }
}
