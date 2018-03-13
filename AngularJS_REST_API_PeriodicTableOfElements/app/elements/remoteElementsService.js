(function () {
	var remoteElementsService = function ($http) {
		
		var _fetchElements = function () {
		    console.log('service: url = ' + 'http://localhost:64227/api/Element');
		    return $http.get('http://localhost:64227/api/Element');
		};

		var _fetchElement = function (id) {
		    console.log('service: url = ' + 'http://localhost:64227/api/Element/' + id);
			return $http.get('http://localhost:64227/api/Element/' + id);
        };
		
        return {
            fetchElements:             _fetchElements, // remember this comma
			fetchElement:				_fetchElement
        };
    }

    angular.module('myAngularApplicationElements').factory('remoteElementsService', ["$http", remoteElementsService]);
}());