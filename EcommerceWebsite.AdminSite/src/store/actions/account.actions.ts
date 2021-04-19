import { Dispatch } from 'react';
import {AccountService} from '../../services/account.service';
import { AccountActionTypes, LOGIN_FAILURE, LOGIN_REQUEST, LOGIN_SUCCESS } from '../contains/account.types';

export const login = (username: string, password: string) =>{
    return async(dispatch: Dispatch<AccountActionTypes>) =>{
        dispatch({
            type: LOGIN_REQUEST,
            payload: {
                username: username,
                password: password
            }
        })
        try{
            const reponse = await AccountService.login(username, password);
            dispatch({
                type: LOGIN_SUCCESS,
                payload: reponse
            })
        } 
        catch(error)
        {
            dispatch({
                type: LOGIN_FAILURE,
                payload:{
                    error: error.toString()
                }
            })
        }
    }
}