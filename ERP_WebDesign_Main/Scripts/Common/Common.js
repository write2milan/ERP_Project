(function () {
    var ERP_APP = angular.module('ERP-APP', ['ERP-CONTROLLER', 'ERP-SERVICE']);
    var controllerModule = angular.module('ERP-CONTROLLER', []);
    var serviceModule = angular.module('ERP-SERVICE', []);

})();

var OpenModalAfterSaveRecord = function (url) {
    $('#thankyouModal').modal({
        backdrop: 'static',
        keyboard: false
    }).one('click', '#ok', function (e) {
        window.location = url;
    });
};

var OnSuccess = function (result) {
    OpenModalAfterSaveRecord(result);
}

var OnFailure = function (result) {
    document.write(result.data);
}

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
}

/**
 * Hides "Please wait" overlay. See function showPleaseWait().
 */
var hidePleaseWait = function () {
    $("#pleaseWaitDialog").modal("hide");
    $("div#pleaseWaitDialog").remove();
}
