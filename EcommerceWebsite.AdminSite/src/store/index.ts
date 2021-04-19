import { combineReducers } from "redux";
import AccountReducer from "./reducers/account.reducers"; 
import { createStore, applyMiddleware } from "redux";
import thunk from 'redux-thunk';

const rootReducer =combineReducers({
    AccountReducer
});
const store = createStore(
    rootReducer,
    applyMiddleware(thunk),
);

export default store;