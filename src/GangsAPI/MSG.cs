﻿using Microsoft.Extensions.Localization;

namespace GangsAPI;

public enum MSG {
  COMMAND_GANG_NOTINGANG,
  COMMAND_GANG_CREATE_ALREADY_EXISTS,
  COMMAND_GANG_CREATE_SUCCESS,
  COMMAND_INVITE_NONE,
  COMMAND_INVITE_MAXINVITES,
  COMMAND_INVITE_ALREADY_INVITED,
  COMMAND_INVITE_ALREADY_IN_GANG,
  COMMAND_INVITE_IN_YOUR_GANG,
  COMMAND_INVITE_SUCCESS,
  COMMAND_INVITE_CANCELED,
  COMMAND_INVITE_NOTFOUND,
  COMMAND_INVITE_FOUNDMULTIPLE,
  GENERIC_STEAM_NOT_FOUND,
  COMMAND_BALANCE_NONE,
  COMMAND_BALANCE,
  COMMAND_BALANCE_GANG,
  COMMAND_BALANCE_GANG_NONE,
  COMMAND_BALANCE_OTHER_NONE,
  COMMAND_BALANCE_OTHER,
  COMMAND_BALANCE_SET,
  COMMAND_GANG_DISBAND_WARN,
  COMMAND_GANG_DISBANDED,
  COMMAND_GANG_KICKED,
  COMMAND_USAGE,
  COMMAND_INVALID_PARAM,
  COMMAND_RANK_EXISTS,
  COMMAND_RANK_CREATED,
  COMMAND_RANK_CANNOT_DELETE,
  COMMAND_RANK_DELETED,
  COMMAND_RANK_RENAMED,
  COMMAND_RANK_RENAME_PROMPT,
  COMMAND_TRANSFER_SUBORDINATE,
  COMMAND_COINFLIP_SENT,
  COMMAND_COINFLIP_RECEIVED,
  COMMAND_COINFLIP_REJECTED,
  COMMAND_COINFLIP_RESULT,
  COMMAND_COINFLIP_COOLDOWN,
  COMMAND_COINFLIP_PENDING,
  COMMAND_COINFLIP_INSUFFICIENT_FUNDS,
  COMMAND_COINFLIP_INSUFFICIENT_FUNDS_OTHER,
  COMMAND_COINFLIP_NOPENDING,
  COMMAND_COINFLIP_INVALID,
  COMMAND_LEAVE_LEFT,
  PREFIX,
  GENERIC_PLAYER_NOT_FOUND,
  GENERIC_PLAYER_FOUND_MULTIPLE,
  GENERIC_PLAYER_ONLY,
  GENERIC_NOPERM,
  GENERIC_NOPERM_NODE,
  GENERIC_NOPERM_RANK,
  GENERIC_ERROR,
  GENERIC_ERROR_INFO,
  CURRENCY,
  GANG_NOT_FOUND,
  GANG_NOT_FOUND_CLOSEST,
  GANG_FULL,
  GANG_POLICY_INVITE_ONLY,
  GANG_POLICY_INVITE_ACCEPTED,
  GANG_POLICY_REQUEST_SENT,
  GANG_POLICY_REQUEST_ALREADY,
  GANG_INVITED,
  GANG_TRANSFERRED,
  GANG_THING_SET,
  COLOR_DEFAULT,
  COLOR_EMPHASIS,
  COLOR_NUMBERL,
  COLOR_SPECIAL,
  COLOR_COMMAND,
  COLOR_CURRENCY,
  COLOR_TARGET,
  COLOR_GANG,
  ALREADY_IN_GANG,
  NOT_IN_GANG,
  PERK_MISSING,
  PERK_PURCHASED,
  PERK_UNPURCHASABLE,
  PERK_UNPURCHASABLE_WITH_ITEM,
  PERK_NOT_FOUND,
  PERK_DISPLAY_CHAT,
  PERK_DISPLAY_SCOREBOARD,
  GANG_CHAT_FORMAT,
  ECO_INSUFFICIENT_FUNDS,
  ECO_INSUFFICIENT_FUNDS_WITH_ITEM,
  ECO_PURCHASED,
  ECO_PURCHASED_WITHITEM,
  ECO_PURCHASED_WITHGANG,
  ECO_PURCHASED_WITHGANG_ITEM,
  ECO_PURCHASED_WITHBOTH,
  ECO_PURCHASED_WITHBOTH_ITEM,
  ECO_PLAYER_GIVE_NEGATIVE,
  ECO_PLAYER_GIVE_POSITIVE,
  ECO_GANG_GIVE_NEGATIVE,
  ECO_GANG_GIVE_POSITIVE,
  RANK_NOT_FOUND,
  RANK_CANNOT_EDIT,
  RANK_MODIFY_GRANT,
  RANK_MODIFY_REVOKE,
  RANK_MODIFY_SET,
  RANK_DEMOTE_BELOW_LOWEST,
  RANK_DEMOTE_SUCCESS,
  RANK_PROMOTE_ABOVE_HIGHEST,
  RANK_PROMOTE_SUCCESS,
  RANK_CANNOT_OWNER,
  COMMAND_GANG_CREATE_INVALID,
  COMMAND_GANG_RESTRICTED,
  COMMAND_INVITE_DOORPOLICY,
}

public static class LocaleExtensions {
  public static string Key(this MSG msg) {
    return msg switch {
      MSG.COMMAND_GANG_NOTINGANG => "command.gang.not_in_gang",
      MSG.COMMAND_GANG_CREATE_ALREADY_EXISTS =>
        "command.gang.create.already_exists",
      MSG.COMMAND_GANG_CREATE_SUCCESS => "command.gang.create.success",
      MSG.COMMAND_INVITE_NONE         => "command.gang.invite.none",
      MSG.COMMAND_INVITE_MAXINVITES   => "command.gang.invite.max_invites",
      MSG.COMMAND_INVITE_ALREADY_INVITED =>
        "command.gang.invite.already_invited",
      MSG.COMMAND_INVITE_ALREADY_IN_GANG =>
        "command.gang.invite.already_ingang",
      MSG.COMMAND_INVITE_IN_YOUR_GANG =>
        "command.gang.invite.already_inyourgang",
      MSG.COMMAND_INVITE_SUCCESS       => "command.gang.invite.success",
      MSG.COMMAND_INVITE_CANCELED      => "command.gang.invite.canceled",
      MSG.COMMAND_INVITE_NOTFOUND      => "command.gang.invite.notfound",
      MSG.COMMAND_INVITE_FOUNDMULTIPLE => "command.gang.invite.foundmultiple",
      MSG.COMMAND_BALANCE_NONE         => "command.balance.none",
      MSG.COMMAND_BALANCE              => "command.balance",
      MSG.COMMAND_BALANCE_OTHER        => "command.balance.other",
      MSG.COMMAND_BALANCE_OTHER_NONE   => "command.balance.other.none",
      MSG.COMMAND_BALANCE_SET          => "command.balance.set",
      MSG.COMMAND_BALANCE_GANG         => "command.balance.gang",
      MSG.COMMAND_BALANCE_GANG_NONE    => "command.balance.gang.none",
      MSG.COMMAND_USAGE                => "command.usage",
      MSG.COMMAND_INVALID_PARAM        => "command.invalid_parameter",
      MSG.COMMAND_GANG_DISBAND_WARN    => "command.gang.disband.warning",
      MSG.COMMAND_GANG_DISBANDED       => "command.gang.disbanded",
      MSG.COMMAND_GANG_KICKED          => "command.gang.kicked",
      MSG.COMMAND_RANK_EXISTS          => "command.rank.exists",
      MSG.COMMAND_RANK_CREATED         => "command.rank.created",
      MSG.COMMAND_RANK_CANNOT_DELETE   => "command.rank.cannot_delete",
      MSG.COMMAND_RANK_DELETED         => "command.rank.deleted",
      MSG.COMMAND_RANK_RENAMED         => "command.rank.renamed",
      MSG.COMMAND_TRANSFER_SUBORDINATE => "command.transfer.subordinate",
      MSG.COMMAND_COINFLIP_SENT        => "command.coinflip.sent",
      MSG.COMMAND_COINFLIP_RECEIVED    => "command.coinflip.received",
      MSG.COMMAND_COINFLIP_REJECTED    => "command.coinflip.rejected",
      MSG.COMMAND_COINFLIP_RESULT      => "command.coinflip.result",
      MSG.COMMAND_COINFLIP_COOLDOWN    => "command.coinflip.cooldown",
      MSG.COMMAND_COINFLIP_PENDING     => "command.coinflip.pending",
      MSG.COMMAND_COINFLIP_INSUFFICIENT_FUNDS =>
        "command.coinflip.insufficient_funds",
      MSG.COMMAND_COINFLIP_INSUFFICIENT_FUNDS_OTHER =>
        "command.coinflip.insufficient_funds.other",
      MSG.COMMAND_COINFLIP_NOPENDING    => "command.coinflip.no_pending",
      MSG.COMMAND_COINFLIP_INVALID      => "command.coinflip.invalid",
      MSG.COMMAND_RANK_RENAME_PROMPT    => "command.rank.rename_prompt",
      MSG.PREFIX                        => "prefix",
      MSG.GENERIC_PLAYER_NOT_FOUND      => "generic.player.not_found",
      MSG.GENERIC_PLAYER_ONLY           => "generic.player.only",
      MSG.GENERIC_STEAM_NOT_FOUND       => "generic.player.steam_not_found",
      MSG.GENERIC_NOPERM                => "generic.no_permission",
      MSG.GENERIC_NOPERM_NODE           => "generic.no_permission.node",
      MSG.GENERIC_NOPERM_RANK           => "generic.no_permission.rank",
      MSG.GENERIC_PLAYER_FOUND_MULTIPLE => "generic.player.found_multiple",
      MSG.GENERIC_ERROR                 => "generic.error",
      MSG.GENERIC_ERROR_INFO            => "generic.error.info",
      MSG.CURRENCY                      => "currency",
      MSG.COLOR_DEFAULT                 => "color.default",
      MSG.COLOR_EMPHASIS                => "color.emph",
      MSG.COLOR_NUMBERL                 => "color.number",
      MSG.COLOR_SPECIAL                 => "color.special",
      MSG.COLOR_COMMAND                 => "color.command",
      MSG.COLOR_CURRENCY                => "color.currency",
      MSG.COLOR_TARGET                  => "color.target",
      MSG.COLOR_GANG                    => "color.gang",
      MSG.ALREADY_IN_GANG               => "gang.already_in_gang",
      MSG.NOT_IN_GANG                   => "gang.not_in_gang",
      MSG.PERK_MISSING                  => "perk.missing",
      MSG.PERK_PURCHASED                => "perk.purchased",
      MSG.PERK_UNPURCHASABLE            => "perk.unpurchasable",
      MSG.PERK_UNPURCHASABLE_WITH_ITEM  => "perk.unpurchasable_withitem",
      MSG.PERK_DISPLAY_CHAT             => "perk.display.chat.toggled",
      MSG.PERK_DISPLAY_SCOREBOARD       => "perk.display.scoreboard.toggled",
      MSG.PERK_NOT_FOUND                => "perk.not_found",
      MSG.GANG_CHAT_FORMAT              => "perk.gangchat.format",
      MSG.GANG_NOT_FOUND                => "gang.not_found",
      MSG.GANG_NOT_FOUND_CLOSEST        => "gang.not_found.closest",
      MSG.GANG_FULL                     => "gang.full",
      MSG.GANG_POLICY_INVITE_ONLY       => "gang.policy.invite_only",
      MSG.GANG_POLICY_REQUEST_SENT      => "gang.policy.request_sent",
      MSG.GANG_POLICY_REQUEST_ALREADY   => "gang.policy.request_already",
      MSG.GANG_POLICY_INVITE_ACCEPTED   => "gang.policy.invite_accepted",
      MSG.GANG_INVITED                  => "gang.invited",
      MSG.GANG_THING_SET                => "gang.thing_set",
      MSG.ECO_INSUFFICIENT_FUNDS        => "eco.insufficient_funds",
      MSG.ECO_INSUFFICIENT_FUNDS_WITH_ITEM =>
        "eco.insufficient_funds.with_item",
      MSG.ECO_PURCHASED => "eco.purchased",
      MSG.ECO_PURCHASED_WITHITEM => "eco.purchased.with_item",
      MSG.ECO_PURCHASED_WITHGANG => "eco.purchased.with_gang",
      MSG.ECO_PURCHASED_WITHGANG_ITEM => "eco.purchased.with_gang.with_item",
      MSG.ECO_PURCHASED_WITHBOTH => "eco.purchased.with_both",
      MSG.ECO_PURCHASED_WITHBOTH_ITEM => "eco.purchased.with_both.with_item",
      MSG.ECO_PLAYER_GIVE_NEGATIVE => "eco.player.granted.negative",
      MSG.ECO_PLAYER_GIVE_POSITIVE => "eco.player.granted.positive",
      MSG.ECO_GANG_GIVE_NEGATIVE => "eco.gang.granted.negative",
      MSG.ECO_GANG_GIVE_POSITIVE => "eco.gang.granted.positive",
      MSG.RANK_NOT_FOUND => "rank.not_found",
      MSG.RANK_CANNOT_EDIT => "rank.cannot_edit",
      MSG.RANK_MODIFY_GRANT => "rank.modify.grant",
      MSG.RANK_MODIFY_REVOKE => "rank.modify.revoke",
      MSG.RANK_MODIFY_SET => "rank.modify.set",
      MSG.RANK_DEMOTE_BELOW_LOWEST => "rank.demote.below_lowest",
      MSG.RANK_DEMOTE_SUCCESS => "rank.demote.success",
      MSG.RANK_PROMOTE_ABOVE_HIGHEST => "rank.promote.above_highest",
      MSG.RANK_PROMOTE_SUCCESS => "rank.promote.success",
      MSG.RANK_CANNOT_OWNER => "rank.cannot.owner",
      MSG.GANG_TRANSFERRED => "gang.transferred",
      MSG.COMMAND_LEAVE_LEFT => "command.leave.left",
      MSG.COMMAND_GANG_CREATE_INVALID => "command.gang.create.invalid",
      MSG.COMMAND_GANG_RESTRICTED => "command.gang.create.restricted",
      MSG.COMMAND_INVITE_DOORPOLICY => "command.gang.invite.doorpolicy",
      _ => throw new ArgumentOutOfRangeException(nameof(msg), msg, null)
    };
  }

  public static string Get(this IStringLocalizer localizer, MSG msg,
    params object[] args) {
    try { return localizer[msg.Key(), args].Value; } catch (FormatException e) {
      throw new FormatException(
        $"There was an error formatting {msg.Key()} ({localizer[msg.Key()]})",
        e);
    }
  }
}