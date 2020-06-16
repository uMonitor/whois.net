namespace src
{
    public class Domain
    {
        enum Status {
            addPeriod,
            autoRenewPeriod,
            inactive,
            ok,
            pendingCreate,
            pendingDelete,
            pendingRenew,
            pendingRestore,
            pendingTransfer,
            pendingUpdate,
            redemptionPeriod,
            renewPeriod,
            serverDeleteProhibited,
            serverHold,
            serverRenewProhibited,
            serverTransferProhibited,
            serverUpdateProhibited,
            transferPeriod
        }
    }
}