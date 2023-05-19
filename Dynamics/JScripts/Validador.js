function alert()
{
    alert('Mensagem de alerta script JS');
}


function ValidarCNPJ(executionContext){
    //valida se recebeu contexto de execução
    if(executionContext === null)
        return;

    //declara variável com o conteúdo do contexto de execução
    var formContext = executionContext.getFormContext();

    //declara variável com o valor do CNPJ digitado pelo usuário
    var cnpj = executionContext.getEventSource().getValue();

    var label = executionContext.getEventSource().getName();

    //declara variável isValid como verdadeira e valida se o CNPJ digitado não é fake
    //caso contrário a variável receberá valor false
    var isValid = true;
    if(cnpj !== null & cnpj !== ""){
        cnpj = cnpj.replace(/[^\d]+/g, '');
        if(cnpj.length !== 14 ||
            cnpj === "00000000000000" ||
            cnpj === "11111111111111" ||
            cnpj === "22222222222222" ||
            cnpj === "33333333333333" ||
            cnpj === "44444444444444" ||
            cnpj === "55555555555555" ||
            cnpj === "66666666666666" ||
            cnpj === "77777777777777" ||
            cnpj === "88888888888888" ||
            cnpj === "99999999999999"){
                isValid = false;
            }

            var tamanho = cnpj.length -2;
            var numeros = cnpj.substring(0, tamanho);
            var digitos = cnpj.substring(tamanho);
            var soma = 0;
            var pos = tamanho - 7;

            for(i = tamanho; i>=1; i--){
                soma += numeros.charAt(tamanho - i) * pos--;
                if(pos<2)
                    pos = 9;
            }

            resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
            if(resultado.toString() !== digitos.charAt(0)){
                isValid = false;
            }

            tamanho = tamanho + 1;
            numeros = cnpj.substring(0, tamanho);
            soma = 0;
            pos = tamanho - 7;
            for(i = tamanho; i>=1; i--){
                soma += numeros.charAt(tamanho - i) * pos--;
                if(pos<2)
                    pos = 9;
            }
            var resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
            if(resultado.toString() !== digitos.charAt(1)){
                isValid = false;
            }
        }
        else{
            isValid = false;
        }

        if(isValid){
            cnpj = cnpj.substring(0, 2) + '.' + cnpj.substring(2, 5) + '.' + cnpj.substring(5, 8) + '/' + cnpj.substring(8, 12) + '-' + cnpj.substring(12);
            cnpj = formContext.getAttribute(label).setValue(cnpj);
        }
        else{
            Xrm.Navigation.openAlertDialog({confirmButtonLabel: "OK", text: "CNPJ" + cnpj + "inválido"}, {height: 100, width: 300}).then(
                function success(result){
                    cnpj = formContext.getAttribute(label).setValue("");
                    formContext.getAttribute(campoSemFormatacao).setValue("");
                }
            )
        }

}

function ValidarCPF(executionContext){
    //valida se recebeu contexto de execução
    if(executionContext === null)
        return;

    //declara variável com o conteúdo do contexto de execução
    var formContext = executionContext.getFormContext();

    //declara variável com o valor do CPF digitado pelo usuário
    var cpf = executionContext.getEventSource().getValue();

    var label = executionContext.getEventSource().getName();

    //declara variável isValid como verdadeira e valida se o CPF digitado não é fake
    //caso contrário a variável receberá valor false
    var isValid = true;
    if(cpf !== null & cpf !== ""){
        cpf = cpf.replace(/[^\d]+/g, '');
        var Soma;
        var Resto;
        Soma = 0;
        if(cpf.length !== 11 ||
            cpf === "000000000000" ||
            cpf === "111111111111" ||
            cpf === "222222222222" ||
            cpf === "333333333333" ||
            cpf === "444444444444" ||
            cpf === "555555555555" ||
            cpf === "666666666666" ||
            cpf === "777777777777" ||
            cpf === "888888888888" ||
            cpf === "999999999999"){
                isValid = false;
            }

            for (i = 1; i <= 9;i++) Soma = Soma + parseInt(cpf.substring(i -1, i)) * (11 - i);
            Resto = (Soma * 10) % 11;

            if ((Resto === 10) || (Resto === 11)) Resto = 0;
            if(Resto !== parseInt(cpf.substring(9, 10))){
                isValid = false;
            }

            Soma = 0;
            for(i = 1; i<=10; i++) Soma = Soma + parseInt(cpf.substring(i - 1, i)) * (12 - i);
            Resto = (Soma * 10) % 11;

            if((Resto === 10) || (Resto === 11)) {Resto = 0;}
            if(Resto !== parseInt(cpf.substring(10, 11))){
                isValid = false;
            }
        }
        else{
            isValid = false;
        }

        if(isValid){
            cpf = cpf.substring(0, 3) + '.' + cpf.substring(3, 6) + '.' + cpf.substring(6, 9) + '-' + cpf.substring(9);
            cpf = formContext.getAttribute(label).setValue(cpf);
        }
        else{
            Xrm.Navigation.openAlertDialog({confirmButtonLabel: "OK", text: "CPF" + cpf + "inválido"}, {height: 100, width: 300}).then(
                function success(result){
                    cpf = formContext.getAttribute(label).setValue("");
                    formContext.getAttribute(campoSemFormatacao).setValue("");
                }
            )
        }

}