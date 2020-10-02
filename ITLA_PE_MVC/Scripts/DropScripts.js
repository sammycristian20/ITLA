$(document).ready(function () {


    $("#Solicitud_GenericID_TipoIdentificacion,#Solicitud_Nombres,#Solicitud_Apellidos,#Solicitud_FechaNacimiento,#Solicitud_IdentificacionCedula").change(function () {
        GenerateID();
        //alert(GiveMe($('#Nombres').val()));
    });

    $("#Solicitud_ProvinciaId").change(function () {
        $.get("/Solicitudes/GetMuniciposList", { ProvinciaId: $("#Solicitud_ProvinciaId").val() }, function (data) {
            // VACIAMOS EL DropDownList
            $("#Solicitud_Idmunicipio").empty();
            // AÑADIMOS UN NUEVO label CON EL NOMBRE DEL ELEMENTO SELECCIONADO
            $("#Solicitud_Idmunicipio").append("<option value>Seleccionar Municipios")
            // CONSTRUIMOS EL DropDownList A PARTIR DEL RESULTADO Json (data)
            $.each(data, function (index, row) {
                $("#Solicitud_Idmunicipio").append("<option value='" + row.IDmunicipio + "'>" + row.Municipio + "</option>")
            });
        });
    });




    $("#Solicitud_GenericID_TipoIdentificacion").change(function () {
      
        //$("#Solicitud_IdentificacionCedula").val("");
        var fecha = new Date($("#Solicitud_FechaNacimiento").val());
            var nombres = $("#Solicitud_Nombres").val();
        var apellidos = $("#Solicitud_Apellidos").val();
        var solicitudDropSel = $("#Solicitud_GenericID_TipoIdentificacion").val();
        var validates = validateEmpty(nombres, apellidos, $("#Solicitud_FechaNacimiento").val());

        //alert('probando cambios');

       

        try {

            if (solicitudDropSel == '10')
            {
                $("#Solicitud_IdentificacionCedula").val("");
            }

            if (solicitudDropSel == "11" && validates == true) {
                // AÑADIMOS UN NUEVO label CON EL NOMBRE DEL ELEMENTO SELECCIONADO
                //var newDate = fecha.getFullYear() + "" + (fecha.getMonth() + 1) + "" + (fecha.getDate() + 1);

                //var Cadena = FirstLatter(nombres, 0) + FirstLatter(nombres, 1) + FirstLatter(apellidos, 0) + FirstLatter(apellidos, 1) + newDate.replace('/', '');
                //$("#Solicitud_IdentificacionCedula").val(Cadena);

                $("#divCedula").hide();
                $("#divActa").show();
                $("#PostFileActa").prop('required', true);
                $("#PostFile").removeAttr('required');
            }
            else if (solicitudDropSel == "11" && validates == false)
            {
                alertify
                    .alert("Debe completar su nombre apellido y fecha de nac..", function () {
                        //alertify.message('OK');
                    });
            }

            /*else {
                $("#Solicitud_IdentificacionCedula").val("");
                $("#divActa").hide();
                $("#divCedula").show();
                $("#PostFile").prop('required', true);
                $("#PostFileActa").removeAttr('required');
            }*/
        }
        catch
        {
        }
        if (solicitudDropSel == "11") {
            $("#divCedula").hide();
            $("#PostFile").removeAttr('required');
            $("#divActa").show();
            $("#PostFileActa").prop('required', true);
            //$('#Solicitud_IdentificacionCedula').attr('disabled', 'disabled');

        }
        else {
            $("#divCedula").show();
            $("#PostFile").prop('required', true);
            $("#divActa").hide();
            $("#PostFileActa").removeAttr('required');
            //$('#Solicitud_IdentificacionCedula').removeAttr('disabled');

        }

    });
    function validateEmpty(nombres, apellidos, fecha) {
        if (nombres != "" && apellidos != "" && fecha !="") {
            return true;
        } else {
            return false;
        }

    }
    function FirstLatter(cadena,idx) {
        var str = cadena;
        var matches = str.match(/\b(\w)/g); // ['J','S','O','N']
        var acronym = matches.join('')[idx]; // JSON
        if (acronym != undefined) {
            return acronym;
        } else {
            return ""
        }
    };

    function GenerateID() {
        if ($("#Solicitud_GenericID_TipoIdentificacion").val() == 11) {
            $('#Solicitud_IdentificacionCedula').val(
                GiveMe($('#Solicitud_Nombres').val())
                +
                GiveMe($('#Solicitud_Apellidos').val())
                +
                $('#Solicitud_FechaNacimiento').val()
            );
        }

    }

    function GiveMe(str) {
        ///alert(str);
        if (str === null || str == '') {
            return '';

        }
        else {
            var matches = str.match(/\b(\w)/g); // ['J','S','O','N']
            return matches.join(''); // JSON

        }

    }

});