(function () {
    var ERP_APP = angular.module('ERP-APP', ['ERP-CONTROLLER', 'ERP-SERVICE']);
    var controllerModule = angular.module('ERP-CONTROLLER', []);
    var serviceModule = angular.module('ERP-SERVICE', []);

})();


var ERP_JS_MAIN = ERP_JS_MAIN || {};

ERP_JS_MAIN = (function () {

    var OpenModalAfterSaveRecord = function (url) {
        $('#thankyouModal').modal({
            backdrop: 'static',
            keyboard: false
        }).one('click', '#ok', function (e) {
            window.location = url;
        });
    };

    var BuildCustomPopUp = function (message) {
        var customModal = $('<div class="custom-modal modal fade" tabindex="-1" role="dialog" aria-hidden="true"><div class="modal-content"><div class="modal-header"><button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button></div><div class="modal-body">An error occurred..</div><div class="modal-footer"><button class="btn" data-dismiss="modal">Close</button></div></div></div>');
        $('body').append(customModal);
        $('.custom-modal').modal();
        $('.custom-modal').on('hidden', function () {
            $('.custom-modal').remove();
        });



    };

    var OnSuccess = function (result) {
        if (result.indexOf("ERPEXCEPTION") === -1)
            OpenModalAfterSaveRecord(result);
        else
            document.write(result);

    };

    var OnFailure = function (result) {
        if (typeof (result.data) === 'undefined')
            BuildCustomPopUp(result.responseText);
        else
            document.write(result.data);
    };

    var showPleaseWait = function () {
        var modalLoading = '<div class="modal" id="pleaseWaitDialog" data-backdrop="static" data-keyboard="false role="dialog">\
        <div class="modal-dialog">\
            <div class="modal-content">\
                <div class="modal-header">\
                    <h4 class="modal-title">Please wait...</h4>\
                </div>\
                <div class="modal-body">\
                    <div class="progress">\
                      <div class="progress-bar progress-bar-success progress-bar-striped active" role="progressbar"\
                      aria-valuenow="100" aria-valuemin="0" aria-valuemax="100" style="width:100%; height: 40px">\
                      </div>\
                    </div>\
                </div>\
            </div>\
        </div>\
    </div>';
        $(document.body).append(modalLoading);
        $("#pleaseWaitDialog").modal("show");
    };

    var hidePleaseWait = function () {
        $("#pleaseWaitDialog").modal("hide");
        $("div#pleaseWaitDialog").remove();
    };

    return {
        OpenModalAfterSaveRecord: OpenModalAfterSaveRecord,
        OnSuccess: OnSuccess,
        OnFailure: OnFailure,
        showPleaseWait: showPleaseWait,
        hidePleaseWait: hidePleaseWait

    }

})();
