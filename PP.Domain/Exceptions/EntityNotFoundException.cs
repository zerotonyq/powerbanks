﻿namespace PP.Domain.Exceptions;

public class EntityNotFoundException : ArgumentException
{
    public EntityNotFoundException(string message) : base(message) {}

}