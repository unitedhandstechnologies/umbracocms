angular.module("umbraco")
    .controller("CustomWelcomeDashboardController",
        function ($rootScope, $scope, $http, $log, assetsService, umbRequestHelper, notificationsService, angularHelper, $timeout, $element) {
           $scope.send = function (name, email, comments, star) {
                if (name != null && email != null) {
                    $scope.isAgreed = false;
                    var FeedbackModel = {
                        feedbackName: name,
                        feedbackEmail: email,
                        feedbackStar: star,
                        feedbackComments: comments,
                        feedbackProjectName: "OskiStarterKit Umbraco 9"
                    };
                    $scope.name = null;
                    $scope.email = null;
                    $scope.star = null;
                    $scope.comments = null;
                    $scope.hidden = false;

                    umbRequestHelper.resourcePromise(
                        $http.post("https://crm00.com/umbraco/api/UserReviews/SaveResultUserReviews", FeedbackModel),
                        'Something went wrong, try sending again').then(function () {
                            notificationsService.success("Thank you, your feedback is important to us");
                        }, function (err) {
                            notificationsService.error(err.errorMsg + "! Status code " + err.status);
                            console.log(err);
                        });
                }
                else {
                    $scope.isAgreed = false;
                    notificationsService.error("\"Name\" and \"email\" fields must be filled in");
                }
            }
        });
