﻿using Fluxor;

namespace FluxorSample.Store.WeatherUseCase;

public static class Reducers
{
    [ReducerMethod]
    public static WeatherState ReduceFetchDataAction(WeatherState state, FetchDataAction action) =>
        new(isLoading: true, forecasts: null);

    [ReducerMethod]
    public static WeatherState ReduceFetchDataResultAction(WeatherState state, FetchDataResultAction action) =>
        new(isLoading: false, forecasts: action.Forecasts);
}
