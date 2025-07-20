﻿using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.Application.UseCases.User.Register;

public class RegisterUserUseCase
{
    public ResponseRegisterUserJson Execute(RequestRegisterUserJson request)
    {

        Validate(request);

        return new ResponseRegisterUserJson
        {
            Name = request.Name,
        };
    }

    private void Validate(RequestRegisterUserJson request)
    {
        var validator = new RegisterUserValidator();

        var result = validator.Validate(request);

        if (result.IsValid == false) {

            var errorMessages = result.Errors.Select(e => e.ErrorMessage);

            throw new Exception();
        }
    }
}