﻿namespace Api.Swagger.ProducesAttributes.ProducesInternalException;

public class InternalExceptionView
{
    [InternalExceptionTitle]
    public required string Title { get; init; }
    [InternalExceptionDetail]
    public required string Detail { get; init; }
}