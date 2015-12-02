(function (angular) {
    "use strict";

    angular
        .module("todoApp")
        .directive("todoPaginatedList", [todoPaginatedList]);

    function todoPaginatedList() {

        var directive = {
            restrict: "E",
            templateUrl: "app/templates/todo.list.paginated.html",
            scope: {},

            controller: ["$scope", "$http", controller],

            link: link
        };

        function controller ($scope, $http) {
            $scope.todos = [];

            // TODO: fetch paginated list
            $http.get("api/Todo/Todos").then(response => $scope.todos = response.data);
        }

        function link(scope, element, attrs) {

        }

        return directive;
    }


})(angular);

