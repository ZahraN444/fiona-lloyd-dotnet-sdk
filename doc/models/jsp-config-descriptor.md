
# Jsp Config Descriptor

## Structure

`JspConfigDescriptor`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Taglibs` | [`List<TaglibDescriptor>`](../../doc/models/taglib-descriptor.md) | Optional | - |
| `JspPropertyGroups` | [`List<JspPropertyGroupDescriptor>`](../../doc/models/jsp-property-group-descriptor.md) | Optional | - |

## Example (as JSON)

```json
{
  "taglibs": [
    {
      "taglibURI": "taglibURI2",
      "taglibLocation": "taglibLocation4"
    }
  ],
  "jspPropertyGroups": [
    {
      "buffer": "buffer0",
      "errorOnUndeclaredNamespace": "errorOnUndeclaredNamespace4",
      "trimDirectiveWhitespaces": "trimDirectiveWhitespaces8",
      "deferredSyntaxAllowedAsLiteral": "deferredSyntaxAllowedAsLiteral4",
      "scriptingInvalid": "scriptingInvalid2"
    },
    {
      "buffer": "buffer0",
      "errorOnUndeclaredNamespace": "errorOnUndeclaredNamespace4",
      "trimDirectiveWhitespaces": "trimDirectiveWhitespaces8",
      "deferredSyntaxAllowedAsLiteral": "deferredSyntaxAllowedAsLiteral4",
      "scriptingInvalid": "scriptingInvalid2"
    }
  ]
}
```

