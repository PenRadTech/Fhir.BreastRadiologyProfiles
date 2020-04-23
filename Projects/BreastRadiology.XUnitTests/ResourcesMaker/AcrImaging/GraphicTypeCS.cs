using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        //# TODO: get from gg
        CSTaskVar GraphicTypeCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "GraphicTypeCS",
                    "GraphicType CodeSystem",
                    "GraphicType/CodeSystem",
                    "GraphicType code system.",
                    ResourcesMaker.Group_AimCodesCS,
                    new ConceptDef[]
                    {
                        #region Codes
                        new ConceptDef()
                            .SetCode("POINT")
                            .SetDisplay("POINT")
                            .SetDefinition(
                                "If Graphic Type is POINT, then two values (one point) " +
                                "shall be specified and the single point specified is" +
                                " to be drawn."),
                        new ConceptDef()
                            .SetCode("POLYLINE")
                            .SetDisplay("POLYLINE")
                            .SetDefinition(
                                "If Graphic Type is POLYLINE, then the points are to be " +
                                "interpreted as an n-tuple list of end points between which " +
                                "straight lines are to be drawn."),
                        new ConceptDef()
                            .SetCode("INTERPOLATED")
                            .SetDisplay("INTERPOLATED")
                            .SetDefinition(
                                "If Graphic Type is INTERPOLATED, then the points are to be " +
                                "interpreted as an n-tuple list of end points between which " +
                                "some form of implementation dependent curved lines are to be " +
                                "drawn. The rendered line shall pass through all the specified " +
                                "points."),
                        new ConceptDef()
                            .SetCode("CIRCLE")
                            .SetDisplay("CIRCLE")
                            .SetDefinition(
                                "If Graphic Type is CIRCLE, then exactly two points shall be " +
                                "present; the first point is to be interpreted as the center " +
                                "and the second point as a point on the circumference of a " +
                                "circle, some form of implementation dependent representation " +
                                "of which is to be drawn."),
                        new ConceptDef()
                            .SetCode("ELLIPSE")
                            .SetDisplay("ELLIPSE")
                            .SetDefinition(
                                "If Graphic Type is ELLIPSE, then exactly four points shall be " +
                                "present; the first two points are to be interpreted as the " +
                                "endpoints of the major axis and the second two points as the " +
                                "endpoints of the minor axis of an ellipse, some form of " +
                                "implementation dependent representation of which is to be " +
                                "drawn."),
                        #endregion
                    })
        );

        VSTaskVar GraphicTypeVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "GraphicTypeVS",
                    "GraphicType ValueSet",
                    "GraphicType/ValueSet",
                    "GraphicType value set.",
                    Group_AimCodesVS,
                    Self.GraphicTypeCS.Value())
        );
    }
}
