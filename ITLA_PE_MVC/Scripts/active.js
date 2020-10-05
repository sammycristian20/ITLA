// Example starter JavaScript for disabling form submissions if there are invalid fields
(function () {
    'use strict';
    window.addEventListener('load', function () {
        // Fetch all the forms we want to apply custom Bootstrap validation styles to
        var forms = document.getElementsByClassName('needs-validation');
        // Loop over them and prevent submission
        var validation = Array.prototype.filter.call(forms, function (form) {
            form.addEventListener('submit', function (event) {
                if (form.checkValidity() === false) {
                    event.preventDefault();
                    event.stopPropagation();
                }
                form.classList.add('was-validated');
            }, false);
        });
    }, false);
})();


$(".custom-file-input").on("change", function () {
    var fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
});


function reset() {
    //$("#toggleCSS").attr("href", "Content/FullLibraries/alertify.js-0.3.11/themes/alertify.default.css");
    alertify.set({
        labels: {
            ok: "SI",
            cancel: "NO"
        },
        delay: 5000,
        buttonReverse: false,
        buttonFocus: "ok"
    });
}

$(document).ready(function () {
    $('#tablelist').DataTable();

    $(".new").on('click', function () {
        reset();
        alertify.confirm("Para enviar una solicitud de Beca ITLA-Ministerio de la Juventud, debe cumplir con estos requisitos: nacionalidad dominicana, tener 16 años en adelante, cédula o acta de nacimiento y comprobante de estudios(Record de notas de bachiller, 2do grado de media aprobado; antes 8vo.curso)<br/><br/> ¿Cumple usted con estos requisitos?", function (e) {
            if (e) {



                window.location.href = '/solicitudes/Create';
                return false;



                //alertify.success("You've clicked OK");
            } else {

                alertify.set({
                    labels: {
                        ok: "OK"
                    }
                });

                alertify.alert("Estimado solicitante, para poder continuar con su solicitud de Beca Puntos Tecnológicos, es necesario tener estos dos documentos consigo. Favor volver más tarde. Le recordamos que la solicitud de convocatoria ciera el 11/10/2020 o cuando se agoten los cupos disponibles.");



            }
        });
        return false;
    });

    $(".status").on('click', function () {
        alertify.prompt('Ingrese el número de su solicitud o su email:',
            function (evt, value) {
                if (value != "") {
                    window.location.href = '/solicitudes/Find?id=' + value;
                } else {
                    alert('1112');
                }

            }

        );
        return false;
    });


    $(".edit").on('click', function () {
        window.location.href = '/solicitudes/generatelinks';
    });
    $('#IdentificacionCedula').mask('000-0000000-0');
    
    $('#Solicitud_IdentificacionCedula').mask('000-0000000-0');
    $('#IdentificacionCedulaEdit').mask('000-0000000-0');
    $('#Solicitud_TelResidencial').mask('000-000-0000');
    $('#Solicitud_TelCelular').mask('000-000-0000');


    $("#Solicitud_IdentificacionCedula").blur(function () {
        if ($("#Solicitud_GenericID_TipoIdentificacion").val() == '10' || $("#Solicitud_GenericID_TipoIdentificacion").val() == '') {
            var cedulaNo = $('#Solicitud_IdentificacionCedula').val();
            if (cedulaNo != '')
                getCedula(cedulaNo);
        }
        else {
            document.getElementById("Solicitud_IdentificacionCedula").setCustomValidity("");
        }
    });

    $("#Solicitud_Email").blur(function () {
        $('#Solicitud_Email').val($('#Solicitud_Email').val().trim().toLowerCase())
        var email = $('#Solicitud_Email').val();
        if (email != '')
            getEmail(email);
    });
    //funciones agregadas para las cedulas y email cuando editamos 
    $("#IdentificacionCedulaEdit").blur(function () {
        if ($("#Solicitud_GenericID_TipoIdentificacion").val() == '10' || $("#Solicitud_GenericID_TipoIdentificacion").val() == '') {
            var cedulaNo = $('#IdentificacionCedulaEdit').val();
            if (cedulaNo != '')
                getCedulaEdit(cedulaNo);
        }
        else {
            document.getElementById("IdentificacionCedulaEdit").setCustomValidity("");
        }
    });

    $("#EmailEdit").blur(function () {
        $('#EmailEdit').val($('#EmailEdit').val().trim().toLowerCase())
        var email = $('#EmailEdit').val();
        if (email != '')
            getEmailEdit(email);
    });

});
function messageAlert(mensaje) {

    alertify.error(mensaje);
}

function getCedula() {
    $.ajax({

        url: "/Solicitudes/validateCedula",
        type: "Post",
        data: JSON.stringify({ "cedula": $('#Solicitud_IdentificacionCedula').val() }),
        contentType: 'application/json; charset=utf-8',
        mode: 'cors',
        headers: {
            'Access-Control-Allow-Origin': '*',
            'Accept': 'application/json',
            'Content-Type': 'application/json',
        },
        success: function (data) {
            if (data != "") {
                document.getElementById("Solicitud_IdentificacionCedula").setCustomValidity("Este cedula ya tiene una solicitud registrada");
                messageAlert(data);
            }
            else {
                document.getElementById("Solicitud_IdentificacionCedula").setCustomValidity("");

            }
        },
        error: function () { alert('error'); }
    });
}

function getEmail() {
    //alert('get email4');
    $.ajax({
        //https://beca-mj.itlard.info
        url: "/Solicitudes/validateEmail",
        type: "Post",
        data: JSON.stringify({ "email": $('#Solicitud_Email').val() }),
        //{ Name: name, 
        // Address: address, DOB: dob },
        mode: 'cors',
        headers: {
            'Access-Control-Allow-Origin': '*',
            'Accept': 'application/json',
            'Content-Type': 'application/json',
        },
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            if (data != "") {
                document.getElementById("Solicitud_Email").setCustomValidity("Este email ya tiene una solicitud registrada");
                messageAlert(data);
            }
            else {
                document.getElementById("Solicitud_Email").setCustomValidity("");

            }
        },
        error: function () { alert('error'); }
    });
}



function getCedulaEdit() {
    var idSols = window.location.href.match(/(\d+)$/g)[0];
    $.ajax({
        url: "/Solicitudes/validateCedulalEdit",
        type: "Post",
        data: JSON.stringify({ "cedula": $('#IdentificacionCedulaEdit').val(), "idSol": idSols }),
        contentType: 'application/json; charset=utf-8',
        mode: 'cors',
        headers: {
            'Access-Control-Allow-Origin': '*',
            'Accept': 'application/json',
            'Content-Type': 'application/json',
        },
        success: function (data) {
            if (data != "") {
                document.getElementById("IdentificacionCedulaEdit").setCustomValidity("Este cedula ya tiene una solicitud registrada por otro usaurio");
                messageAlert(data);
            }
            else {
                document.getElementById("IdentificacionCedulaEdit").setCustomValidity("");

            }
        },
        error: function () { alert('error'); }
    });
}


function getEmailEdit() {

    var idSols = window.location.href.match(/(\d+)$/g)[0];
    $.ajax({
        url: "/Solicitudes/validateEmailEdit",
        type: "Post",
        data: JSON.stringify({ "email": $('#EmailEdit').val(), "idSol": idSols  }),
        //{ Name: name, 
        // Address: address, DOB: dob },
        mode: 'cors',
        headers: {
            'Access-Control-Allow-Origin': '*',
            'Accept': 'application/json',
            'Content-Type': 'application/json',
        },
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            if (data != "") {
                document.getElementById("EmailEdit").setCustomValidity("Este email ya tiene una solicitud registrada por otro usuario");
                messageAlert(data);
            }
            else {
                document.getElementById("EmailEdit").setCustomValidity("");

            }
        },
        error: function () { alert('error'); }
    });
}

function checkForm(obj) {
    $('#mySubmit').html('Procesando favor esperar...');
    $('#mySubmit').attr('disabled', 'disabled');


    return true;
    //alert('submit');
}
function onlyAlphabets(e, t) {
    try {
        if (window.event) {
            var charCode = window.event.keyCode;
        }
        else if (e) {
            var charCode = e.which;
        }
        else {
            return true;
        }

        if ((charCode > 64 && charCode < 91) || (charCode > 96 && charCode < 123) || charCode == 32)
            return true;
        else
            return false;
    }
    catch (err) {
        //alert(err.Description);
    }
}


