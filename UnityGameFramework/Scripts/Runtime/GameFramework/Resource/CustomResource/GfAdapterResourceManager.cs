using GameFramework;
using GameFramework.Download;
using GameFramework.FileSystem;
using GameFramework.ObjectPool;
using GameFramework.Resource;
using System;
using System.Collections.Generic;

public  class GFAdapterResourceManager : IResourceManager
{
    private ICustomResourceManager m_ToCustomResourceManager;

    public void LaunchCustomAsset(ICustomResourceManager sManager, Action complete)
    {
        m_ToCustomResourceManager = sManager;
        m_ToCustomResourceManager.LaunchAsset(complete);
    } 

    public static readonly GFAdapterResourceManager Instance = new();

    public bool UseCustomManager => true;

    public string ReadOnlyPath => "";

    public string ReadWritePath => "";

    public ResourceMode ResourceMode => ResourceMode.Package;

    public string CurrentVariant => "";

    public PackageVersionListSerializer PackageVersionListSerializer => null;

    public UpdatableVersionListSerializer UpdatableVersionListSerializer => null;

    public ReadOnlyVersionListSerializer ReadOnlyVersionListSerializer => null;

    public ReadWriteVersionListSerializer ReadWriteVersionListSerializer => null;

    public ResourcePackVersionListSerializer ResourcePackVersionListSerializer => null;

    public string ApplicableGameVersion => "";

    public int InternalResourceVersion => 0;

    public int AssetCount => 0;

    public int ResourceCount => 0;

    public int ResourceGroupCount => 0;

    public string UpdatePrefixUri { get; set; }
    public int GenerateReadWriteVersionListLength { get; set; }

    public string ApplyingResourcePackPath => null;

    public int ApplyWaitingCount => 0;

    public int UpdateRetryCount { get; set; }

    public IResourceGroup UpdatingResourceGroup => null;

    public int UpdateWaitingCount => 0;

    public int UpdateWaitingWhilePlayingCount => 0;

    public int UpdateCandidateCount => 0;

    public int LoadTotalAgentCount => 0;

    public int LoadFreeAgentCount => 0;

    public int LoadWorkingAgentCount => 0;

    public int LoadWaitingTaskCount => 0;

    public float AssetAutoReleaseInterval { get ; set; }
    public int AssetCapacity { get; set; }
    public float AssetExpireTime { get; set; }
    public int AssetPriority { get; set; }
    public float ResourceAutoReleaseInterval { get; set; }
    public int ResourceCapacity { get; set; }
    public float ResourceExpireTime { get; set; }
    public int ResourcePriority { get; set; }

    public event EventHandler<ResourceVerifyStartEventArgs> ResourceVerifyStart;
    public event EventHandler<ResourceVerifySuccessEventArgs> ResourceVerifySuccess;
    public event EventHandler<ResourceVerifyFailureEventArgs> ResourceVerifyFailure;
    public event EventHandler<ResourceApplyStartEventArgs> ResourceApplyStart;
    public event EventHandler<ResourceApplySuccessEventArgs> ResourceApplySuccess;
    public event EventHandler<ResourceApplyFailureEventArgs> ResourceApplyFailure;
    public event EventHandler<ResourceUpdateStartEventArgs> ResourceUpdateStart;
    public event EventHandler<ResourceUpdateChangedEventArgs> ResourceUpdateChanged;
    public event EventHandler<ResourceUpdateSuccessEventArgs> ResourceUpdateSuccess;
    public event EventHandler<ResourceUpdateFailureEventArgs> ResourceUpdateFailure;
    public event EventHandler<ResourceUpdateAllCompleteEventArgs> ResourceUpdateAllComplete;

    public void AddLoadResourceAgentHelper(ILoadResourceAgentHelper loadResourceAgentHelper)
    {
       
    }

    public void ApplyResources(string resourcePackPath, ApplyResourcesCompleteCallback applyResourcesCompleteCallback)
    {
        
    }

    public void CheckResources(bool ignoreOtherVariant, CheckResourcesCompleteCallback checkResourcesCompleteCallback)
    {
        
    }

    public CheckVersionListResult CheckVersionList(int latestInternalResourceVersion)
    {
        return CheckVersionListResult.NeedUpdate;
    }

    public TaskInfo[] GetAllLoadAssetInfos()
    {
        return null;
    }

    public void GetAllLoadAssetInfos(List<TaskInfo> results)
    {
        return;
    }

    public IResourceGroup[] GetAllResourceGroups()
    {
        return null;
    }

    public void GetAllResourceGroups(List<IResourceGroup> results)
    {
        
    }

    public int GetBinaryLength(string binaryAssetName)
    {
        return 0;
    }

    public string GetBinaryPath(string binaryAssetName)
    {
        return null;
    }

    public bool GetBinaryPath(string binaryAssetName, out bool storageInReadOnly, out bool storageInFileSystem, out string relativePath, out string fileName)
    {
        storageInReadOnly = storageInFileSystem= false;

        fileName = relativePath = null;
        return false;
    }

    public IResourceGroup GetResourceGroup()
    {
        return null;
    }

    public IResourceGroup GetResourceGroup(string resourceGroupName)
    {
        return null;
    }

    public IResourceGroupCollection GetResourceGroupCollection(params string[] resourceGroupNames)
    {
        return null;
    }

    public IResourceGroupCollection GetResourceGroupCollection(List<string> resourceGroupNames)
    {
        return null;
    }

    public HasAssetResult HasAsset(string assetName)
    {
        return HasAssetResult.AssetOnDisk;
    }

    public bool HasResourceGroup(string resourceGroupName)
    {
        return false;
    }

    public void InitResources(InitResourcesCompleteCallback initResourcesCompleteCallback)
    {

    }

    public void LoadAsset(string assetName, LoadAssetCallbacks loadAssetCallbacks)
    {
        m_ToCustomResourceManager.ToLoadAsset(assetName, null, 0, loadAssetCallbacks, null);
    }

    public void LoadAsset(string assetName, Type assetType, LoadAssetCallbacks loadAssetCallbacks)
    {
        m_ToCustomResourceManager.ToLoadAsset(assetName, assetType, 0, loadAssetCallbacks, null);
    }

    public void LoadAsset(string assetName, int priority, LoadAssetCallbacks loadAssetCallbacks)
    {
        m_ToCustomResourceManager.ToLoadAsset(assetName, null, priority, loadAssetCallbacks, null);
    }

    public void LoadAsset(string assetName, LoadAssetCallbacks loadAssetCallbacks, object userData)
    {
        m_ToCustomResourceManager.ToLoadAsset(assetName, null, 0, loadAssetCallbacks, userData);
    }

    public void LoadAsset(string assetName, Type assetType, int priority, LoadAssetCallbacks loadAssetCallbacks)
    {
        m_ToCustomResourceManager.ToLoadAsset(assetName, assetType, priority, loadAssetCallbacks, null);
    }

    public void LoadAsset(string assetName, Type assetType, LoadAssetCallbacks loadAssetCallbacks, object userData)
    {
        m_ToCustomResourceManager.ToLoadAsset(assetName, assetType, 0, loadAssetCallbacks, userData);
    }

    public void LoadAsset(string assetName, int priority, LoadAssetCallbacks loadAssetCallbacks, object userData)
    {
        m_ToCustomResourceManager.ToLoadAsset(assetName, null, priority, loadAssetCallbacks, userData);
    }

    public void LoadAsset(string assetName, Type assetType, int priority, LoadAssetCallbacks loadAssetCallbacks, object userData)
    {

        m_ToCustomResourceManager.ToLoadAsset(assetName, assetType, priority, loadAssetCallbacks, userData);
        //throw new NotImplementedException();
    }

    public void LoadBinary(string binaryAssetName, LoadBinaryCallbacks loadBinaryCallbacks)
    {
        throw new NotImplementedException();
    }

    public void LoadBinary(string binaryAssetName, LoadBinaryCallbacks loadBinaryCallbacks, object userData)
    {
        throw new NotImplementedException();
    }

    public byte[] LoadBinaryFromFileSystem(string binaryAssetName)
    {
        throw new NotImplementedException();
    }

    public int LoadBinaryFromFileSystem(string binaryAssetName, byte[] buffer)
    {
        throw new NotImplementedException();
    }

    public int LoadBinaryFromFileSystem(string binaryAssetName, byte[] buffer, int startIndex)
    {
        throw new NotImplementedException();
    }

    public int LoadBinaryFromFileSystem(string binaryAssetName, byte[] buffer, int startIndex, int length)
    {
        throw new NotImplementedException();
    }

    public byte[] LoadBinarySegmentFromFileSystem(string binaryAssetName, int length)
    {
        throw new NotImplementedException();
    }

    public byte[] LoadBinarySegmentFromFileSystem(string binaryAssetName, int offset, int length)
    {
        throw new NotImplementedException();
    }

    public int LoadBinarySegmentFromFileSystem(string binaryAssetName, byte[] buffer)
    {
        throw new NotImplementedException();
    }

    public int LoadBinarySegmentFromFileSystem(string binaryAssetName, byte[] buffer, int length)
    {
        throw new NotImplementedException();
    }

    public int LoadBinarySegmentFromFileSystem(string binaryAssetName, byte[] buffer, int startIndex, int length)
    {
        throw new NotImplementedException();
    }

    public int LoadBinarySegmentFromFileSystem(string binaryAssetName, int offset, byte[] buffer)
    {
        throw new NotImplementedException();
    }

    public int LoadBinarySegmentFromFileSystem(string binaryAssetName, int offset, byte[] buffer, int length)
    {
        throw new NotImplementedException();
    }

    public int LoadBinarySegmentFromFileSystem(string binaryAssetName, int offset, byte[] buffer, int startIndex, int length)
    {
        throw new NotImplementedException();
    }

    public void LoadScene(string sceneAssetName, LoadSceneCallbacks loadSceneCallbacks)
    {
        m_ToCustomResourceManager.ToLoadScene(sceneAssetName, loadSceneCallbacks , 0 ,null);
    }

    public void LoadScene(string sceneAssetName, int priority, LoadSceneCallbacks loadSceneCallbacks)
    {
        m_ToCustomResourceManager.ToLoadScene(sceneAssetName, loadSceneCallbacks, priority, null);
    }

    public void LoadScene(string sceneAssetName, LoadSceneCallbacks loadSceneCallbacks, object userData)
    {
        m_ToCustomResourceManager.ToLoadScene(sceneAssetName, loadSceneCallbacks, 0, userData);
    }

    public void LoadScene(string sceneAssetName, int priority, LoadSceneCallbacks loadSceneCallbacks, object userData)
    {
        m_ToCustomResourceManager.ToLoadScene(sceneAssetName, loadSceneCallbacks, priority, userData);
    }

    public void SetCurrentVariant(string currentVariant)
    {

    }

    public void SetDecryptResourceCallback(DecryptResourceCallback decryptResourceCallback)
    {

    }

    public void SetDownloadManager(IDownloadManager downloadManager)
    {
    }

    public void SetFileSystemManager(IFileSystemManager fileSystemManager)
    {
    }

    public void SetObjectPoolManager(IObjectPoolManager objectPoolManager)
    {
    }

    public void SetReadOnlyPath(string readOnlyPath)
    {
    }

    public void SetReadWritePath(string readWritePath)
    {
    }

    public void SetResourceHelper(IResourceHelper resourceHelper)
    {
    }

    public void SetResourceMode(ResourceMode resourceMode)
    {
    }

    public void StopUpdateResources()
    {
    }

    public void UnloadAsset(object asset)
    {
        m_ToCustomResourceManager.ToUnloadAsset(asset);
    }

    public void UnloadScene(string sceneAssetName, UnloadSceneCallbacks unloadSceneCallbacks)
    {
        m_ToCustomResourceManager.ToUnloadScene(sceneAssetName, unloadSceneCallbacks, null);
    }

    public void UnloadScene(string sceneAssetName, UnloadSceneCallbacks unloadSceneCallbacks, object userData)
    {
        m_ToCustomResourceManager.ToUnloadScene(sceneAssetName, unloadSceneCallbacks, userData);
    }

    public void UpdateResources(UpdateResourcesCompleteCallback updateResourcesCompleteCallback)
    {
    }

    public void UpdateResources(string resourceGroupName, UpdateResourcesCompleteCallback updateResourcesCompleteCallback)
    {
    }

    public void UpdateVersionList(int versionListLength, int versionListHashCode, int versionListCompressedLength, int versionListCompressedHashCode, UpdateVersionListCallbacks updateVersionListCallbacks)
    {
    }

    public bool VerifyResourcePack(string resourcePackPath)
    {
        return false;
    }

    public void VerifyResources(int verifyResourceLengthPerFrame, VerifyResourcesCompleteCallback verifyResourcesCompleteCallback)
    {                                 
    }
}
